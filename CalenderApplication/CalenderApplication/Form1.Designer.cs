﻿
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.Calendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Calendar);
            this.tabControl.Controls.Add(this.Weather);
            this.tabControl.Controls.Add(this.Calculator);
            this.tabControl.Controls.Add(this.Notes);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Location = new System.Drawing.Point(14, 45);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(887, 779);
            this.tabControl.TabIndex = 0;
            // 
            // Calendar
            // 
            this.Calendar.AccessibleDescription = "";
            this.Calendar.AccessibleName = "";
            this.Calendar.BackColor = System.Drawing.Color.Crimson;
            this.Calendar.Controls.Add(this.monthCalendar1);
            this.Calendar.Location = new System.Drawing.Point(4, 29);
            this.Calendar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Calendar.Name = "Calendar";
            this.Calendar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Calendar.Size = new System.Drawing.Size(879, 746);
            this.Calendar.TabIndex = 0;
            this.Calendar.Text = "Calendar";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.monthCalendar1.Location = new System.Drawing.Point(36, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCalendar1.TabIndex = 0;
            // 
            // Weather
            // 
            this.Weather.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Weather.Location = new System.Drawing.Point(4, 29);
            this.Weather.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Weather.Name = "Weather";
            this.Weather.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Weather.Size = new System.Drawing.Size(879, 746);
            this.Weather.TabIndex = 1;
            this.Weather.Text = "Weather";
            // 
            // Calculator
            // 
            this.Calculator.BackColor = System.Drawing.Color.Pink;
            this.Calculator.Location = new System.Drawing.Point(4, 29);
            this.Calculator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Calculator.Name = "Calculator";
            this.Calculator.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Calculator.Size = new System.Drawing.Size(879, 746);
            this.Calculator.TabIndex = 2;
            this.Calculator.Text = "Calculator";
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.Yellow;
            this.Notes.Location = new System.Drawing.Point(4, 29);
            this.Notes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Notes.Name = "Notes";
            this.Notes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Notes.Size = new System.Drawing.Size(879, 746);
            this.Notes.TabIndex = 3;
            this.Notes.Text = "Notes";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Size = new System.Drawing.Size(879, 746);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 840);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Widget Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.Calendar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Calendar;
        private System.Windows.Forms.TabPage Weather;
        private System.Windows.Forms.TabPage Calculator;
        private System.Windows.Forms.TabPage Notes;
        private System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

