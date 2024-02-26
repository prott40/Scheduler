/*Author Preston Rottinghaus
* file: Worker.cs
*/
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.Scheduler
{
    /// <summary>
    /// tells us about the workers being assigned tasks
    /// </summary>
    public class Worker
    {
        //field 1 private
        /// <summary>
        /// array that tells weather the worker is 
        /// qualifed for that task starting at 0
        /// </summary>
        private bool[] _qualifications;
        // 2 public propery name TimesScheduled
        /// <summary>
        ///  gets the name of the worker
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// gets the numbwer of times a worker has been scheduled 
        /// </summary>
        public int TimesScheduled { get; set; }
        // public constructor Worker
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameWork"></param>
        public Worker(string[] nameWork)
        {
            // if null throw exception
            if (nameWork == null)
            {
                throw new ArgumentNullException();
            }
            // if empty throw exception
            if (nameWork.Length == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                //fill qualification array
                _qualifications = new bool[nameWork.Length - 1];
                //set name to first value
                Name = nameWork[0];
            }

            // iterate through the tastks
            for (int ct = 0; ct < _qualifications.Length; ct++)
            {
                // if has an empty string
                if (nameWork[ct + 1] == "")
                {
                    // set value to false
                    _qualifications[ct] = false;
                }
                else
                {

                    // when has value becomes true
                    _qualifications[ct] = true;
                }

            }
        }
        // public method IsQualified
        /// <summary>
        /// checks weather the worker is qualified
        /// </summary>
        /// <param name="task"> the task to check</param>
        /// <returns>if the user is qualified</returns>
        public bool IsQualified(int task)
        {
            //when the taskk number is invalid throw error
            if (!(task >= 0 && task < _qualifications.Length))
            {
                throw new ArgumentException();
            }
            else
            {
                // othewise retun their qulification
                return _qualifications[task];
            }


        }
    }
}