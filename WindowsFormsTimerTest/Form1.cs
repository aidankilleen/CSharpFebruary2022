using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTimerTest
{
    public partial class Form1 : Form
    {
        public int Count { get; set; } = 0;
        public int ManualCount { get; set; } = 0;

        public int BackgroundWorkerCount { get; set; } = 0;

        public bool running = false;

        public Form1()
        {
            InitializeComponent();

            
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            Count++;
            txtCount.Text = $"{ Count }";

            
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                running = true;
                tmrMain.Start();
                btnTimer.Text = "Stop";

            } else
            {
                running = false;
                tmrMain.Stop();
                btnTimer.Text = "Start";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtManualCount.Text= $"{ ManualCount++ }";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtManualCount.Text = $"{ ManualCount-- }";
        }

        private void btnSlow_Click(object sender, EventArgs e)
        {
            btnSlow.Enabled = false;

            Thread.Sleep(5000);

            btnSlow.Enabled = true;
        }

        private void bwMain_DoWork(object sender, DoWorkEventArgs e)
        {
            // time consuming function

            for (int i=0; i<1000; i++)
            {

                if (bwMain.CancellationPending)
                {
                    bwMain.ReportProgress(0);
                    return;
                }
                bwMain.ReportProgress(i / 10);
                Thread.Sleep(10);
            }
        }

        private void btnStartBackgroundWorker_Click(object sender, EventArgs e)
        {
            btnStartBackgroundWorker.Enabled = false;
            btnCancel.Enabled = true;
            bwMain.RunWorkerAsync();
        }

        private void bwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStartBackgroundWorker.Enabled = true;
            btnCancel.Enabled = false;
            MessageBox.Show("Background Worker Finished");
        }

        private void bwMain_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            txtBackgroundWorkerCount.Text = $"{ BackgroundWorkerCount++ }";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bwMain.CancelAsync();
        }
    }
}
