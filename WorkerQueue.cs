/*Author Preston Rottinghaus
 * file: WorkerQueue.cs
*/
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.Scheduler
{
    /// <summary>
    /// holds the queue to asign workers to a job
    /// </summary>
    public class WorkerQueue
    {
        /// <summary>
        /// worker field
        /// </summary>
        private Worker _newGuy;
        /// <summary>
        /// sets the front cell;
        /// </summary>
        private DoublyLinkedListCell _front;
        /// <summary>
        /// sets the back cell;
        /// </summary>
        private DoublyLinkedListCell _back;
        /// <summary>
        /// queue holding all workers
        /// </summary>
        public WorkerQueue()
        {
            // creatas empty string
            string[] s = new string[] {""}; 
            // sets up header workers
            _newGuy = new Worker(s);
            // sets front worker
            _front = new DoublyLinkedListCell(_newGuy);
            // sets back worker
            _back = new DoublyLinkedListCell(_newGuy);
            // sets the nest valeu from front to back and value before back to front
            _front.Next = _back;
            _back.Previous = _front;
        }
        /// <summary>
        /// adds a new worker to queue
        /// </summary>
        /// <param name="c">current worker</param>
        /// <exception cref="ArgumentNullException"> if the worker is a fake worker</exception>
        public void Enqueue(Worker c)
        {
            // if the worker is a null
            if(c == null)
            {
                throw new ArgumentNullException();
            }
            // otherwise create new doubly linked list
            DoublyLinkedListCell current = new(c);
            // set its previos value to the value begore end
            current.Previous = _back.Previous;
            // sets its next valeu to end
            current.Next = _back;
            current.Previous!.Next = current;
            current.Next.Previous = current;
            
        }
        /// <summary>
        /// searches for first qualified worker
        /// </summary>
        /// <param name="task">task number</param>
        /// <returns>correct worker</returns>
        public Worker? DequeueFirstQualified(int task)
        {
            // creates pointer to look through list
            //never null as it is set to first cell
            DoublyLinkedListCell pointer = _front.Next!;
            // while not at the back of list
            while(pointer != _back)
            {
                // if the worker is qulaifuied
                if (pointer!.Data!.IsQualified(task))
                {
                    // pulls the value out of list by setin previous value to next
                    pointer.Next!.Previous = pointer.Previous;
                    pointer.Previous!.Next = pointer.Next;
                    //returns the correct worker
                    return pointer.Data;
                }
                //if not a valid job goes to next worker
                pointer = pointer.Next!;
            }
            // nobody can do this job
            return null;
        }
    }
}
