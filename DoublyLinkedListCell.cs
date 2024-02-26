/*Author Preston Rottinghaus
 * file: DoublyLinkedListCell.cs
*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.Scheduler
{
    /// <summary>
    /// a double linked list 
    /// </summary>
    public class DoublyLinkedListCell
    {
        /// <summary>
        /// get the worker for list
        /// </summary>
        public Worker ?Data { get; } 
        /// <summary>
        /// gets teh next cell
        /// </summary>
        public DoublyLinkedListCell ?Next { get; set; }
        /// <summary>
        /// gets the prevois cell
        /// </summary>
        public DoublyLinkedListCell ?Previous { get; set; }
        /// <summary>
        /// creates a linked list objec
        /// </summary>
        /// <param name="data">worker tha will  be put itno list</param>
        /// <exception cref="ArgumentNullException"> if there is a null value</exception>
        public DoublyLinkedListCell(Worker data)
        {
            //check for a null worker
            if(data == null)
            {
                throw new ArgumentNullException();
            }
            // sets the data property to current worker
            Data = data;
            // set next value to self and previos valeu to self
            Next = this;
            Previous = this;
        }
    }
}
