/*Author Preston Rottinghaus
 * file:Schedule.cs
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.Scheduler
{
    /// <summary>
    /// creates the schedule
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// contailes the schedule
        /// </summary>
        private readonly string[][] _schedule;
        /// <summary>
        /// length of _schedule
        /// </summary>
        public int Length { get => _schedule.Length; }
       /// <summary>
       /// indexes through the schedule array
       /// </summary>
       /// <param name="day">the day for scheduling</param>
       /// <param name="task"> number of task lokin at</param>
       /// <returns> return the worker name for that day</returns>
        public string this[int day, int task] 
        {
            get => _schedule[day][task];
        
        }
        /// <summary>
        /// creates a queue of the workers
        /// </summary>
        /// <param name="list">the list of workers read in</param>
        /// <returns> the created queue</returns>
        private static WorkerQueue GetQueue(Worker[] list )
        {
            // creates new queue
            WorkerQueue queue = new();
            // loops through the 
            for(int i =0;i< list.Length; i++)
            {
                // sets the number of times schedueed to 0
                list[i].TimesScheduled = 0;
                // addeds the new worker to queue
                queue.Enqueue(list[i]);
            }
            //returns the queue
            return queue;
        }
        /// <summary>
        /// gets day for setting tasks
        /// </summary>
        /// <param name="queue">the queue of workers to look through</param>
        /// <param name="tasks"> number of tasks to have</param>
        /// <returns>sring array workers assigned to that task on each day</returns>
        private static string[] GetOneDay(WorkerQueue queue, int tasks)
        {
            //creates the list of workers for task
            string[] workList = new string[tasks] ;
            // loops through list of possible workers
            for(int i = 0; i < tasks; i++){
                // the first worker who is eiglbe for job
                Worker? first = queue.DequeueFirstQualified(i);
                if ( first != null)
                {
                    // increases the number of times scheduled
                    first.TimesScheduled++;
                    /// will not be null as it checked by if statment
                    workList[i] = first.Name!;
                    // adds worker to the back of queue
                    queue.Enqueue(first);
                }
                //if nobody qualifies place empty sttring
                else
                {
                    // insets a blank space 
                    workList[i] = "";
                }
            }
            //string returned whose length is number of tasks with each elemnet containing the worker for that task
            return workList;
           
        }
        /// <summary>
        /// creates the schedule
        /// </summary>
        /// <param name="listWork">list of workers</param>
        /// <param name="tasks"> total number of tasks</param>
        /// <param name="day"> total number of days</param>
        public Schedule(Worker[] listWork, int tasks, int day)
        {
            // if the list of workers is empty
            if(listWork == null) 
            { 
                throw new ArgumentNullException();
            }
            // sets the scedule 
            _schedule = new string[day][];
            // crettes a new queue from the list of workers
            WorkerQueue created = GetQueue(listWork);
            // iterterate through the days
            for(int i =0;i < day; i++)
            {
                // creates a list of tasks from each day
            string[] taskList = GetOneDay(created, tasks);
                // set teh schedule a that point to created list of workers
                _schedule[i] = taskList;
            }
        }

    }
}
