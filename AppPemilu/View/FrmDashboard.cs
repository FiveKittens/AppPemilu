using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin.View
{
    public partial class FrmDashboard : Form
    {
        View.FrmLoading loading;
        private Entity.EntLogin login;
        public FrmDashboard()
        {
            loading = new View.FrmLoading();
            login = new Entity.EntLogin();
            InitializeComponent();
            rtBox.ReadOnly = true;
        }

        public void AturButton(Boolean status)
        {
            btnCount.Enabled = status;
            btnInput.Enabled = status;
            btnOut.Enabled = status;
            btnRekap.Enabled = status;
            
        }
        private void cancelAsyncButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
                // Close the AlertForm
                loading.Close();
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
                // Close the AlertForm
                loading.Close();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; i <= 10; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    AturButton(true);
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    worker.ReportProgress(i * 10);
                    System.Threading.Thread.Sleep(500);
                }
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Pass the progress to AlertForm label and progressbar
            loading.Message = "In progress, please wait... " + e.ProgressPercentage.ToString() + "%";
            loading.ProgressBar = e.ProgressPercentage;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Close the AlertForm
            loading.Close();
            AturButton(true);
        }
        private void Form4_Load(object sender, EventArgs e)
        {

            label2.Text = login.getID();
            label4.Text = login.getUser();

            if (backgroundWorker1.IsBusy != true)
            {
                loading.Canceled += new EventHandler<EventArgs>(buttonCancel_Click);
                loading.Show();
                AturButton(false);
                loading.TopMost = true;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.TopLevel = false;
            f2.AutoScroll = true;
            this.panel1.Controls.Add(f2);
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            FrmInputCalon f3 = new FrmInputCalon();
            f3.ShowDialog();
            this.Hide();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            FrmLogin f1 = new FrmLogin();
            f1.ShowDialog();
            this.Hide();
        }

        private void btnRekap_Click(object sender, EventArgs e)
        {
            View.FrmRekap f7 = new View.FrmRekap();
            f7.ShowDialog();
            this.Hide();
        }
       
    }
}
