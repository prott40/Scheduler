namespace Ksu.Cis300.Scheduler
{
    partial class UserInterface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uxMenuStrip1 = new MenuStrip();
            uxFileTool = new ToolStripMenuItem();
            uxOpenData = new ToolStripMenuItem();
            uxComputeSchedule = new ToolStripMenuItem();
            uxSaveSchedule = new ToolStripMenuItem();
            uxScheduleLength = new ToolStripMenuItem();
            uxViewScheduleLength = new ToolStripTextBox();
            uxTabControl = new TabControl();
            uxScheduleData = new TabPage();
            uxDataList = new ListView();
            uxComputedSchedule = new TabPage();
            uxComputedList = new ListView();
            uxOpen = new OpenFileDialog();
            uxSave = new SaveFileDialog();
            uxMenuStrip1.SuspendLayout();
            uxTabControl.SuspendLayout();
            uxScheduleData.SuspendLayout();
            uxComputedSchedule.SuspendLayout();
            SuspendLayout();
            // 
            // uxMenuStrip1
            // 
            uxMenuStrip1.ImageScalingSize = new Size(32, 32);
            uxMenuStrip1.Items.AddRange(new ToolStripItem[] { uxFileTool, uxScheduleLength, uxViewScheduleLength });
            uxMenuStrip1.Location = new Point(0, 0);
            uxMenuStrip1.Name = "uxMenuStrip1";
            uxMenuStrip1.Size = new Size(800, 43);
            uxMenuStrip1.TabIndex = 0;
            uxMenuStrip1.Text = "menuStrip1";
            // 
            // uxFileTool
            // 
            uxFileTool.DropDownItems.AddRange(new ToolStripItem[] { uxOpenData, uxComputeSchedule, uxSaveSchedule });
            uxFileTool.Name = "uxFileTool";
            uxFileTool.Size = new Size(71, 39);
            uxFileTool.Text = "File";
            // 
            // uxOpenData
            // 
            uxOpenData.Name = "uxOpenData";
            uxOpenData.Size = new Size(351, 44);
            uxOpenData.Text = "Open Data File";
            uxOpenData.Click += OpenClick;
            // 
            // uxComputeSchedule
            // 
            uxComputeSchedule.Enabled = false;
            uxComputeSchedule.Name = "uxComputeSchedule";
            uxComputeSchedule.Size = new Size(351, 44);
            uxComputeSchedule.Text = "Compute Schedule";
            uxComputeSchedule.Click += ComputeClick;
            // 
            // uxSaveSchedule
            // 
            uxSaveSchedule.Enabled = false;
            uxSaveSchedule.Name = "uxSaveSchedule";
            uxSaveSchedule.Size = new Size(351, 44);
            uxSaveSchedule.Text = "Save Schedule";
            uxSaveSchedule.Click += SaveClick;
            // 
            // uxScheduleLength
            // 
            uxScheduleLength.Name = "uxScheduleLength";
            uxScheduleLength.Size = new Size(225, 39);
            uxScheduleLength.Text = "Schedule Length: ";
            uxScheduleLength.Click += SetLengthClick;
            // 
            // uxViewScheduleLength
            // 
            uxViewScheduleLength.Name = "uxViewScheduleLength";
            uxViewScheduleLength.ReadOnly = true;
            uxViewScheduleLength.Size = new Size(100, 39);
            uxViewScheduleLength.Text = "10";
            // 
            // uxTabControl
            // 
            uxTabControl.Controls.Add(uxScheduleData);
            uxTabControl.Controls.Add(uxComputedSchedule);
            uxTabControl.Dock = DockStyle.Fill;
            uxTabControl.Location = new Point(0, 43);
            uxTabControl.Name = "uxTabControl";
            uxTabControl.SelectedIndex = 0;
            uxTabControl.Size = new Size(800, 407);
            uxTabControl.TabIndex = 2;
            uxTabControl.Tag = "";
            // 
            // uxScheduleData
            // 
            uxScheduleData.Controls.Add(uxDataList);
            uxScheduleData.Location = new Point(8, 46);
            uxScheduleData.Name = "uxScheduleData";
            uxScheduleData.Padding = new Padding(3);
            uxScheduleData.Size = new Size(784, 353);
            uxScheduleData.TabIndex = 0;
            uxScheduleData.Text = "Schedule Data";
            uxScheduleData.UseVisualStyleBackColor = true;
            // 
            // uxDataList
            // 
            uxDataList.Dock = DockStyle.Fill;
            uxDataList.GridLines = true;
            uxDataList.Location = new Point(3, 3);
            uxDataList.Name = "uxDataList";
            uxDataList.Size = new Size(778, 347);
            uxDataList.TabIndex = 0;
            uxDataList.UseCompatibleStateImageBehavior = false;
            uxDataList.View = View.Details;
            // 
            // uxComputedSchedule
            // 
            uxComputedSchedule.Controls.Add(uxComputedList);
            uxComputedSchedule.Location = new Point(8, 46);
            uxComputedSchedule.Name = "uxComputedSchedule";
            uxComputedSchedule.Padding = new Padding(3);
            uxComputedSchedule.Size = new Size(784, 353);
            uxComputedSchedule.TabIndex = 1;
            uxComputedSchedule.Text = "Computed Schedule";
            uxComputedSchedule.UseVisualStyleBackColor = true;
            // 
            // uxComputedList
            // 
            uxComputedList.Dock = DockStyle.Fill;
            uxComputedList.GridLines = true;
            uxComputedList.Location = new Point(3, 3);
            uxComputedList.Name = "uxComputedList";
            uxComputedList.Size = new Size(778, 347);
            uxComputedList.TabIndex = 0;
            uxComputedList.UseCompatibleStateImageBehavior = false;
            uxComputedList.View = View.Details;
            // 
            // uxOpen
            // 
            uxOpen.FileName = "openFileDialog1";
            // 
            // UserInterface
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uxTabControl);
            Controls.Add(uxMenuStrip1);
            MainMenuStrip = uxMenuStrip1;
            Name = "UserInterface";
            Text = "Task Scheduler";
            uxMenuStrip1.ResumeLayout(false);
            uxMenuStrip1.PerformLayout();
            uxTabControl.ResumeLayout(false);
            uxScheduleData.ResumeLayout(false);
            uxComputedSchedule.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip uxMenuStrip1;
        private ToolStripMenuItem uxFileTool;
        private ToolStripMenuItem uxScheduleLength;
        private ToolStripTextBox uxViewScheduleLength;
        private ToolStripMenuItem uxOpenData;
        private ToolStripMenuItem uxComputeSchedule;
        private ToolStripMenuItem uxSaveSchedule;
        private TabControl uxTabControl;
        private TabPage uxScheduleData;
        private TabPage uxComputedSchedule;
        private ListView uxDataList;
        private ListView uxComputedList;
        private OpenFileDialog uxOpen;
        private SaveFileDialog uxSave;
    }
}