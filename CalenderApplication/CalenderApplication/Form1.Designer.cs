
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl.SuspendLayout();
            this.Calendar.SuspendLayout();
            this.Notes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Calendar);
            this.tabControl.Controls.Add(this.Weather);
            this.tabControl.Controls.Add(this.Calculator);
            this.tabControl.Controls.Add(this.Notes);
            this.tabControl.Controls.Add(this.Clock);
            this.tabControl.Location = new System.Drawing.Point(12, 34);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 584);
            this.tabControl.TabIndex = 0;
            // 
            // Calendar
            // 
            this.Calendar.AccessibleDescription = "";
            this.Calendar.AccessibleName = "";
            this.Calendar.BackColor = System.Drawing.Color.Crimson;
            this.Calendar.Controls.Add(this.monthCalendar1);
            this.Calendar.Location = new System.Drawing.Point(4, 24);
            this.Calendar.Name = "Calendar";
            this.Calendar.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Calendar.Size = new System.Drawing.Size(768, 556);
            this.Calendar.TabIndex = 0;
            this.Calendar.Text = "Calendar";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.monthCalendar1.Location = new System.Drawing.Point(32, 7);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCalendar1.TabIndex = 0;
            // 
            // Weather
            // 
            this.Weather.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Weather.Location = new System.Drawing.Point(4, 24);
            this.Weather.Name = "Weather";
            this.Weather.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Weather.Size = new System.Drawing.Size(768, 556);
            this.Weather.TabIndex = 1;
            this.Weather.Text = "Weather";
            // 
            // Calculator
            // 
            this.Calculator.BackColor = System.Drawing.Color.Pink;
            this.Calculator.Location = new System.Drawing.Point(4, 24);
            this.Calculator.Name = "Calculator";
            this.Calculator.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Calculator.Size = new System.Drawing.Size(768, 556);
            this.Calculator.TabIndex = 2;
            this.Calculator.Text = "Calculator";
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.LightBlue;
            this.Notes.Controls.Add(this.dateTimePicker1);
            this.Notes.Controls.Add(this.textBox1);
            this.Notes.Location = new System.Drawing.Point(4, 24);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Notes.Size = new System.Drawing.Size(768, 556);
            this.Notes.TabIndex = 3;
            this.Notes.Text = "Notes";
            // 
            // Clock
            // 
            this.Clock.Location = new System.Drawing.Point(4, 24);
            this.Clock.Name = "Clock";
            this.Clock.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Clock.Size = new System.Drawing.Size(768, 556);
            this.Clock.TabIndex = 4;
            this.Clock.Text = "Clock";
            this.Clock.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(697, 476);
            this.textBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(290, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 630);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Widget Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.Calendar.ResumeLayout(false);
            this.Notes.ResumeLayout(false);
            this.Notes.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
<<<<<<< HEAD

=======
>>>>>>> d8907646987f88ab41d38c729cd1992b963c40d3
    }
}

