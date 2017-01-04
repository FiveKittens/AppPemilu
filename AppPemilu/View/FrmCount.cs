using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class Form2 : Form
    {
        View.FrmLoading loading;
        private DataSet data;
        private Timer time;
        private Entity.EntSuara suara;
        private Interface.IntSuara suaraDao;
        public Form2()
        {
            time = new Timer();
            loading = new View.FrmLoading();
            InitializeComponent();
            suara = new Entity.EntSuara();
            suaraDao = Factory.FactLogin.GetInterfaceSuara();
            TampilDataCalon();
        }
        public void AturButton(Boolean status)
        {
            /*btnCabut.Enabled = status;
            btnInput.Enabled = status;
            btnClose.Enabled = status;
            btnRekap.Enabled = status;*/

        }
        private void cancelAsyncButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
                loading.Close();
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
                loading.Close();
                AturButton(true);
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
                    worker.ReportProgress(i * 10);
                    System.Threading.Thread.Sleep(500);
                }
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loading.Message = "In progress, please wait... " + e.ProgressPercentage.ToString() + "%";
            loading.ProgressBar = e.ProgressPercentage;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loading.Close();
            AturButton(true);
        }
        public void TampilDataCalon()
        {
            data = new DataSet();
            data = suaraDao.SelectSuara();
            dgvSuara.DataSource = data;
            dgvSuara.DataMember = "tb_suara";
            dgvSuara.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuara.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            SelectDataGrid();           
        }
        public void SelectDataGrid()
        {
            int nRowIndex = dgvSuara.Rows.Count - 1;

            dgvSuara.CurrentCell = dgvSuara.Rows[nRowIndex].Cells[0];
        }
        public Decimal TotalSuara()
        {
            decimal Total = 0;
            for(int i = 0; i < dgvSuara.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dgvSuara.Rows[i].Cells["suara_masuk"].Value);
            }
            lblTotal.Text = Total.ToString();
            return Total;
        }
        private void Time_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string jam = "";

            if(hh < 10)
            {
                jam += "0" + hh;
            }
            else
            {
                jam += hh;
            }
            jam += ":";
            if (mm < 10)
            {
                jam += "0" + mm;
            }
            else
            {
                jam += mm;
            }
            jam += ":";
            if (ss < 10)
            {
                jam += "0" + ss;
            }
            else
            {
                jam += ss;
            }
            lblTime.Text = jam;
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            TotalSuara();
            if (backgroundWorker1.IsBusy != true)
            {
                loading.Canceled += new EventHandler<EventArgs>(buttonCancel_Click);
                loading.Show();
                AturButton(false);
                loading.TopMost = true;
                backgroundWorker1.RunWorkerAsync();
            }
            JamAsik();
        }
        private void JamAsik()
        {
            time.Interval = 1000;
            time.Tick += new EventHandler(this.Time_Tick);
            time.Start();
        }
        private void btnInput_Click(object sender, EventArgs e)
        {
            View.FrmInputSuara f5 = new View.FrmInputSuara();
            f5.ShowDialog(this);
            TampilDataCalon();
            TotalSuara();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            View.FrmDashboard f4 = new View.FrmDashboard();
            f4.Show();
            this.Dispose();
        }
        private void btnRekap_Click(object sender, EventArgs e)
        {
            View.FrmRekap f7 = new View.FrmRekap();
            f7.Show();
            this.Hide();
        }
        private void btnCabut_Click(object sender, EventArgs e)
        {
            View.FrmCabutSuara f8 = new View.FrmCabutSuara();
            f8.ShowDialog(this);
            TampilDataCalon();;
        }
       
    }
}