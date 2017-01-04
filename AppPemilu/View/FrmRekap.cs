using DGVPrinterHelper;
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
    public partial class FrmRekap : Form
    {
        private DataSet data;
        private Timer time;
        private Interface.IntSuara suaraDao;
        public FrmRekap()
        {
            time = new Timer();
            suaraDao = Factory.FactLogin.GetInterfaceSuara();
            InitializeComponent();
            TampilDataRekap();
            JamAsik();
        }
        public void TampilDataRekap()
        {
            data = new DataSet();
            data = suaraDao.rekapSuara();
            dgvRekap.DataSource = data.Tables["tb_rekap"];
            this.dgvRekap.Sort(this.dgvRekap.Columns["waktu_suara"], ListSortDirection.Ascending);
        }
        private void Time_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string jam = "";

            if (hh < 10)
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
            lblJam.Text = jam;
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
        private void JamAsik()
        {
            time.Interval = 1000;
            time.Tick += new EventHandler(this.Time_Tick);
            time.Start();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Rekap Suara";
            printer.SubTitle = string.Format("tanggal: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = false;
            printer.CellAlignment = StringAlignment.Center;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "KPUD Yogyakarta";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintPreviewDataGridView(dgvRekap);
            printer.PrintDataGridView(dgvRekap);
            
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            View.FrmInputSuara f5 = new View.FrmInputSuara();
            f5.ShowDialog(this);
            TampilDataRekap();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            View.FrmCabutSuara f8 = new View.FrmCabutSuara();
            f8.ShowDialog(this);
            TampilDataRekap();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            View.FrmDashboard f4 = new View.FrmDashboard();
            f4.Show();
            this.Dispose();
        }
        
    }
}
