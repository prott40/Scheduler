namespace Ksu.Cis300.Scheduler
{
    partial class ScheduleLengthDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uxScheduleLengthSet = new FlowLayoutPanel();
            uxlabel = new Label();
            uxSetLength = new NumericUpDown();
            uxOkButton = new Button();
            uxScheduleLengthSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uxSetLength).BeginInit();
            SuspendLayout();
            // 
            // uxScheduleLengthSet
            // 
            uxScheduleLengthSet.AutoSize = true;
            uxScheduleLengthSet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uxScheduleLengthSet.Controls.Add(uxlabel);
            uxScheduleLengthSet.Controls.Add(uxSetLength);
            uxScheduleLengthSet.Controls.Add(uxOkButton);
            uxScheduleLengthSet.Dock = DockStyle.Fill;
            uxScheduleLengthSet.FlowDirection = FlowDirection.TopDown;
            uxScheduleLengthSet.Location = new Point(0, 0);
            uxScheduleLengthSet.Name = "uxScheduleLengthSet";
            uxScheduleLengthSet.Size = new Size(667, 403);
            uxScheduleLengthSet.TabIndex = 0;
            // 
            // uxlabel
            // 
            uxlabel.AutoSize = true;
            uxlabel.Location = new Point(3, 0);
            uxlabel.Name = "uxlabel";
            uxlabel.Size = new Size(193, 32);
            uxlabel.TabIndex = 0;
            uxlabel.Text = "Schedule Length";
            // 
            // uxSetLength
            // 
            uxSetLength.Location = new Point(3, 35);
            uxSetLength.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            uxSetLength.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            uxSetLength.Name = "uxSetLength";
            uxSetLength.Size = new Size(240, 39);
            uxSetLength.TabIndex = 1;
            uxSetLength.TextAlign = HorizontalAlignment.Right;
            uxSetLength.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // uxOkButton
            // 
            uxOkButton.DialogResult = DialogResult.OK;
            uxOkButton.Location = new Point(3, 80);
            uxOkButton.Name = "uxOkButton";
            uxOkButton.Size = new Size(150, 46);
            uxOkButton.TabIndex = 2;
            uxOkButton.Text = "OK";
            uxOkButton.UseVisualStyleBackColor = true;
            // 
            // ScheduleLengthDialog
            // 
            AcceptButton = uxOkButton;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(667, 403);
            Controls.Add(uxScheduleLengthSet);
            MaximizeBox = false;
            Name = "ScheduleLengthDialog";
            Text = "ScheduleLengthDialog";
            uxScheduleLengthSet.ResumeLayout(false);
            uxScheduleLengthSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uxSetLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel uxScheduleLengthSet;
        private Label uxlabel;
        public NumericUpDown uxSetLength;
        public Button uxOkButton;
    }
}