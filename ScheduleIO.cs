/*Author Preston Rottinghaus
 * file: ScheduleIO.cs
*/
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.Scheduler
{
    /// <summary>
    /// creates the file output and input for schedules
    /// </summary>
    public class ScheduleIO
    {
        /// <summary>
        /// holds the day of the week
        /// </summary>
        public static readonly string _day = "day";
        /// <summary>
        /// holds min number of days
        /// </summary>
        private const int _minDays = 2;
        /// <summary>
        /// reads the input file for dislpay
        /// </summary>
        /// <param name="fn">file name to be opened</param>
        /// <returns>arrays of data from csv</returns>
        public static (string[], Worker[]) ReadInput(string fn)
        {
            // if the file name is empty
            if (fn == null)
            {
                throw new ArgumentNullException();
            }
            // read in all lines
            string[] lines = File.ReadAllLines(fn);
            // creates worker list 
            Worker[] listWorkers = new Worker[lines.Length - 1];
            // the number if number of lines is less than 2
            if (lines.Length < _minDays)
            {
                throw new IOException("The file doesn't have enough lines.");
            }
            // seperetes teh header line into the name and task
            string[] header = lines[0].Split(",");
            // the string containing the tasks
            string[] tasks = new string[header.Length - 1];
            //loop the length of header
            for (int i = 1; i < header.Length; i++)
            {
                //copy over the tasks from header
                tasks[i - 1] = header[i];
            }
            // loop the number of lines
            for (int i = 1; i < lines.Length; i++)
            {
                // reads line into new string of all wualifications
                string[] qualification = lines[i].Split(",");
                // if the length of the qualifications is smaller than the number of tasks
                if (qualification.Length - 1 != tasks.Length)
                {
                    throw new IOException("Line " + i + "contains the wrong number of fields.");
                }
                // creates a new worker with qualifications
                Worker newGuy = new(qualification);
                // adds worler to list 
                listWorkers[i - 1] = newGuy;
            }
            //returns tupple of tasks and workers
            return (tasks, listWorkers);
        }
        /// <summary>
        /// writes the finished scheducle
        /// </summary>
        /// <param name="s">given schedule</param>
        /// <param name="task">number of tasks</param>
        /// <param name="fn">file to write too</param>
        public static void WriteOutput(Schedule s, string[] task,string fn)
        {
            // if any paramets are null
            if(s == null||task == null||fn == null)
            {
                throw new ArgumentNullException();
            }
            //with the stream wrtiter
            using (StreamWriter sw = new(fn))
            {
                // insetrt day name
               sw.Write(_day);
                // loop and write each column an task name
                for(int i = 0; i < task.Length; i++)
                {
                    sw.Write("," + task[i]);
                }
                // write new line
                sw.WriteLine();
                // iterate throght the entre
                for(int row = 0; row< s.Length; row++)
                {
                    for (int col = 0; col < task.Length; col++)
                    {
                        if(col == 0)
                        {
                            // writes the colomn number
                            sw.Write(row + 1);
                            sw.Write(",");
                        }
                        // writes the qualification the last task
                       if(col == task.Length - 1)
                        {
                            sw.Write(s[row, col]);
                            sw.WriteLine();
                        }
                       // writes every task in between
                        else
                        {
                            sw.Write(s[row, col] + ",");
                        }
                        
                    }
                }
                
               
            }
        }

    }
}
