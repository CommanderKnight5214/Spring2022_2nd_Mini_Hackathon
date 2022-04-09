
namespace CalenderApplication
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Calendar = new System.Windows.Forms.TabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Weather = new System.Windows.Forms.TabPage();
            this.Calculator = new System.Windows.Forms.TabPage();
            this.Notes = new System.Windows.Forms.TabPage();
            this.Clock = new System.Windows.Forms.TabPage();
            this.clock1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.Calendar.SuspendLayout();
            this.Clock.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Calendar);
            this.tabControl.Controls.Add(this.Weather);
            this.tabControl.Controls.Add(this.Calculator);
            this.tabControl.Controls.Add(this.Notes);
            this.tabControl.Controls.Add(this.Clock);
            this.tabControl.Location = new System.Drawing.Point(35, 108);
            this.tabControl.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(2218, 1870);
            this.tabControl.TabIndex = 0;
            // 
            // Calendar
            // 
            this.Calendar.AccessibleDescription = "";
            this.Calendar.AccessibleName = "";
            this.Calendar.BackColor = System.Drawing.Color.Crimson;
            this.Calendar.Controls.Add(this.monthCalendar1);
            this.Calendar.Location = new System.Drawing.Point(12, 69);
            this.Calendar.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Calendar.Name = "Calendar";
            this.Calendar.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Calendar.Size = new System.Drawing.Size(2194, 1789);
            this.Calendar.TabIndex = 0;
            this.Calendar.Text = "Calendar";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.monthCalendar1.Location = new System.Drawing.Point(90, 22);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(22);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCalendar1.TabIndex = 0;
            // 
            // Weather
            // 
            this.Weather.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Weather.Location = new System.Drawing.Point(12, 69);
            this.Weather.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Weather.Name = "Weather";
            this.Weather.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Weather.Size = new System.Drawing.Size(2194, 1789);
            this.Weather.TabIndex = 1;
            this.Weather.Text = "Weather";
            // 
            // Calculator
            // 
            this.Calculator.BackColor = System.Drawing.Color.Pink;
            this.Calculator.Location = new System.Drawing.Point(12, 69);
            this.Calculator.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Calculator.Name = "Calculator";
            this.Calculator.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Calculator.Size = new System.Drawing.Size(2194, 1789);
            this.Calculator.TabIndex = 2;
            this.Calculator.Text = "Calculator";
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.Yellow;
            this.Notes.Location = new System.Drawing.Point(12, 69);
            this.Notes.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Notes.Size = new System.Drawing.Size(2194, 1789);
            this.Notes.TabIndex = 3;
            this.Notes.Text = "Notes";
            // 
            // Clock
            // 
            this.Clock.Controls.Add(this.clock1);
            this.Clock.Location = new System.Drawing.Point(12, 69);
            this.Clock.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Clock.Name = "Clock";
            this.Clock.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Clock.Size = new System.Drawing.Size(2194, 1789);
            this.Clock.TabIndex = 4;
            this.Clock.Text = "Clock";
            this.Clock.UseVisualStyleBackColor = true;
            // 
            // clock1
            // 
            this.clock1.AutoSize = true;
            this.clock1.Font = new System.Drawing.Font("Segoe UI", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clock1.Location = new System.Drawing.Point(264, 174);
            this.clock1.Name = "clock1";
            this.clock1.Size = new System.Drawing.Size(1520, 478);
            this.clock1.TabIndex = 0;
            this.clock1.Text = "00:00:00";
            this.clock1.Click += new System.EventHandler(this.clock1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2352, 2016);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Name = "MainForm";
            this.Text = "Widget Application";
            this.tabControl.ResumeLayout(false);
            this.Calendar.ResumeLayout(false);
            this.Clock.ResumeLayout(false);
            this.Clock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Calendar;
        private System.Windows.Forms.TabPage Weather;
        private System.Windows.Forms.TabPage Calculator;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.TabPage Clock;
        public System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label clock1;
    }
}

