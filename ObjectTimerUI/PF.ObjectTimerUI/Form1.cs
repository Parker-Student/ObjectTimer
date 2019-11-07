using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF.ObjectTimerUI
{
    public partial class Form1 : Form
    {

        DateTime startTime = new DateTime();
        TimeSpan elapsedTime = new TimeSpan();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime = DateTime.Now - startTime;
             lblTime.Text = elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            //resetBtn.Enabled = true;
            timer1.Interval = (1000) * (1);
            timer1.Enabled = true;
            timer1.Start();
            startTime = DateTime.Now;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
           // resetBtn.Enabled = true;
            timer1.Stop();
        }
    }
}
