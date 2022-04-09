using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CalenderApplication
{
    public partial class MainForm : Form
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        public MainForm()
        {
            InitializeComponent();
        }

        private void clock1_Click(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh =DateTime.Now.Hour;
            int mm =DateTime.Now.Minute;
            int ss =DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }

            time += ";";
            
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }

            time += ";";
            
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            
            clock1.Text = time;

        }
    }
}
