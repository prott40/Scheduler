/*Author Preston Rottinghaus
 * file: UserInterface.cs
*/
using System.Runtime.CompilerServices;
using System.Windows.Forms.Design;

namespace Ksu.Cis300.Scheduler
{
    /// <summary>
    /// holds the fuctions of all controlls
    /// </summary>
    public partial class UserInterface : Form
    {
        /// <summary>
        /// holds the name of first column
        /// </summary>
        private static readonly string _nameHeading = "Name";
        /// <summary>
        /// sign for a qualified worker
        /// </summary>
        private static readonly string _qualifiedMarker = "X";
        /// <summary>
        /// length of the schedule
        /// </summary>
        private readonly ScheduleLengthDialog _lengthDialog = new();
        /// <summary>
        /// holds names of tasks
        /// </summary>
        private string[] _tasks = Array.Empty<string>();
        /// <summary>
        /// holds all workers
        /// </summary>
        private Worker[] _workers = Array.Empty<Worker>();
        /// <summary>
        /// holds the schedule
        /// </summary>
        private Schedule? _schedule;
        /// <summary>
        /// initializes the form
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// opens the file and tranferes grid
        /// </summary>
        /// <param name="sender"> user clicking open</param>
        /// <param name="e"> action to be done</param>
        private void OpenClick(object sender, EventArgs e)
        {
            // set filter of file dialog to csv only
            uxOpen.Filter = "CSV spreadsheet files|*.csv|All files|*.*";
            // sets the file name empty
            uxOpen.FileName = "";
            // if the dialog box is closed with ok
            if (uxOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //uses the scheduleIO because its static
                    (_tasks, _workers) = ScheduleIO.ReadInput(uxOpen.FileName);
                    //clear the computed output
                    uxComputedList.Clear();
                    //starts update for the schedule
                    uxDataList.BeginUpdate();
                    //clear the list
                    uxDataList.Clear();
                    //adds the colomn headeres
                    uxDataList.Columns.Add(_nameHeading);
                    AddTaskHeadings(uxDataList);
                    // iterates through worker list
                    foreach (Worker w in _workers)
                    {
                        //creates a row with the name of each worker
                        ListViewItem rows = uxDataList.Items.Add(w.Name);
                        //iterates through each task
                        for (int i = 0; i < _tasks.Length; i++)
                        {
                            // if its qualified adds an x to it
                            if (w.IsQualified(i) == true)
                            {
                                rows.SubItems.Add(_qualifiedMarker);
                            }
                            //otherwise adds blank
                            else
                            {
                                rows.SubItems.Add("");
                            }
                        }

                    }
                    // sets the colomn width
                    SetColumnWidth(uxDataList);
                    // ends the update
                    uxDataList.EndUpdate();
                    // selects the correct tab
                    uxTabControl.SelectTab(uxScheduleData);
                    // enables the compute tab
                    uxComputeSchedule.Enabled = true;
                    // disables the saved schedulue
                    uxSaveSchedule.Enabled = false;
                }
                // if there is an exception show in message box
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }


        }
        /// <summary>
        /// returns the statistics for computed schedule
        /// </summary>
        private void ShowStatistics()
        {
            //number of empty stapces
            int none = 0;
            // will not be null as is alwyas initialiwzed to 0
            int max = (int)_workers[0].TimesScheduled!;
            // min number of scedules
            int min = max;
            for (int i = 1; i < _workers.Length; i++)
            {
                // if worker times is 0
                if (_workers[i].TimesScheduled == 0)
                {
                    none++;
                }
                //is current is large than previous 
                else if (_workers[i].TimesScheduled > max)
                {
                    max = (int)_workers[i].TimesScheduled!;
                }
                // if smaller tan min set to min
                else if (_workers[i].TimesScheduled < min)
                {
                    min = (int)_workers[i].TimesScheduled!;
                }
            }
            // shows the stats back
            MessageBox.Show("Each worker was Scheduled a minimum of " + min.ToString() + " times and a maximumum of " + max.ToString() + " times. " + none.ToString() + " Workers were unscheduled.");
        }
        /// <summary>
        /// saves the scedule file
        /// </summary>
        /// <param name="sender">object interacting with file</param>
        /// <param name="e">event that us bing handled</param>
        private void SaveClick(object sender, EventArgs e)
        {
            // resets the file name and filter
            uxSave.FileName = "";
            uxSave.Filter = "CSV spreadsheet files|*.csv|All files|*.*";
            // ope save dialog
                if (uxSave.ShowDialog() == DialogResult.OK)
                {
                //try and save
                try
                {
                    // writes the schedule io output
                    ScheduleIO.WriteOutput(_schedule!, _tasks, uxSave.FileName);
                    // message box out that file has read
                    MessageBox.Show("File successfully saved.");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
               

                }
            
        }
        /// <summary>
        /// sets the schedule length
        /// </summary>
        /// <param name="sender">buton clisck to set scedule</param>
        /// <param name="e">action tha happends</param>
        private void SetLengthClick(object sender, EventArgs e)
        {
            // gets the scedule dialog
            ScheduleLengthDialog schedule = new();
            // if they select ok
            if (schedule.ShowDialog() == DialogResult.OK)
            {
                // it returns the value enteed in the other textbox
                uxViewScheduleLength.Text = schedule.uxSetLength.Value.ToString();
            }
        }
        /// <summary>
        /// puts the list of tasks in list
        /// </summary>
        /// <param name="uxDataList">the list that will be added in</param>
        private void AddTaskHeadings(ListView uxDataList)
        {
            // iterates through the tasks
            foreach(string t in _tasks)
            {
                //sets the label name 
                ColumnHeader labelName = uxDataList.Columns.Add(t);
                // set the align ment of text box
                labelName.TextAlign = HorizontalAlignment.Center;
            }
            // ads blank columsn
            uxDataList.Columns.Add("");
        }
        /// <summary>
        /// sets the width of the columns 
        /// </summary>
        /// <param name="uxDataList"> the list whose widths are to be set</param>
        private void SetColumnWidth(ListView uxDataList)
        {
            //iteratesnthrough the headers in the column list
            foreach (ColumnHeader labelName in uxDataList.Columns)
            {
                // resizes label names for header
                labelName.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
                // holds width of label names
                int widthU = labelName.Width;
                // resizes the column with column contets
                labelName.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                // checks this width
                int widthD = labelName.Width;
                // finds the max width
                labelName.Width = Math.Max(widthU, widthD);
            }
        }
        /// <summary>
        /// compute the schedule
        /// </summary>
        /// <param name="sender">person doing cation</param>
        /// <param name="e">the event that caused it</param>
        private void ComputeClick(object sender, EventArgs e)
        {
            //convetet textbox value to integer 
            int length = Convert.ToInt32(uxViewScheduleLength.Text);
            // builds the schedule to be displayed
            Schedule built = new(_workers, _tasks.Length, length);
            // sets the scedule built to the field
            _schedule = built;
            //start updated for the fisnished scedule
            uxComputedList.BeginUpdate();
            // clears data list
            uxComputedList.Clear();
            // adds the column names to list
            uxComputedList.Columns.Add(_nameHeading);
            // ats the columns
            AddTaskHeadings(uxComputedList);
            //iterates through the workers
            for(int w = 0; w< _workers.Length;w++)
            {
                //creates listview of eac row with worker value
                ListViewItem rows = uxComputedList.Items.Add(w.ToString());
                // iterates through task
                for (int i = 0; i < _tasks.Length; i++)
                {
                        //adds the schedule to listview
                        rows.SubItems.Add(_schedule[w, i]);
                    
                   
                }

            }
            // sets the column width
            SetColumnWidth(uxComputedList);
            // ends update
            uxComputedList.EndUpdate();
            // selects the tab
            uxTabControl.SelectTab(uxComputedSchedule);
            //enables save
            uxSaveSchedule.Enabled = true;
            //shows stats
            ShowStatistics();
        }
    }
}