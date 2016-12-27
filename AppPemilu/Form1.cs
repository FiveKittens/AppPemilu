using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace AppPemilu
{
    public partial class Form1 : Form
    {
        private Entity.EntLogin login;
        private Interface.IntSuara suaraDao;
        public Form1()
        {
            login = new Entity.EntLogin();
            suaraDao = Factory.FactLogin.GetInterfaceSuara();
            InitializeComponent();
            expandCollapsePanel2.IsExpanded = false;
            AturExpanded(false);
            AturButton(false);
            lblID.Text = login.getID();
            lblNama.Text = login.getUser();
            this.KeyPreview = true;
            KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void AturExpanded(bool status)
        {
            foreach (Control item in expandCollapsePanel2.Controls)
            {
                item.Enabled = status;
            }
        }
        private void AturButton(bool status)
        {
            btnPrint.Enabled = status;
        }
        private void btnCount_Click(object sender, EventArgs e)
        {
            LoadCount();
        }
        private void LoadCount()
        {
            if (!paneLoad.Controls.Contains(Count.U1))
            {
                AturExpanded(true);
                AturButton(false);
                expandCollapsePanel1.IsExpanded = false;
                expandCollapsePanel2.IsExpanded = true;
                paneLoad.Controls.Add(Count.U1);
                Count.U1.Dock = DockStyle.Fill;
                Count.U1.BringToFront();
            }
            else
            {
                AturExpanded(true);
                AturButton(false);
                expandCollapsePanel1.IsExpanded = false;
                expandCollapsePanel2.IsExpanded = true;
                Count.U1.BringToFront();
            }
        }
        private void btnManage_Click(object sender, EventArgs e)
        {
            LoadManage();
        }
        private void LoadManage()
        {
            if (!paneLoad.Controls.Contains(Manage.U2))
            {
                AturExpanded(false);
                AturButton(false);
                expandCollapsePanel2.IsExpanded = false;
                paneLoad.Controls.Add(Manage.U2);
                Manage.U2.Dock = DockStyle.Fill;
                Manage.U2.BringToFront();
            }
            else
            {
                AturExpanded(false);
                AturButton(false);
                expandCollapsePanel1.IsExpanded = true;
                expandCollapsePanel2.IsExpanded = false;
                Manage.U2.BringToFront();
            }
        }
        private void btnRekap_Click(object sender, EventArgs e)
        {
            LoadRekap();
        }
        private void LoadRekap()
        {
            if (!paneLoad.Controls.Contains(Rekap.U3))
            {
                AturExpanded(true);
                AturButton(true);
                expandCollapsePanel1.IsExpanded = false;
                expandCollapsePanel2.IsExpanded = true;
                paneLoad.Controls.Add(Rekap.U3);
                Rekap.U3.Dock = DockStyle.Fill;
                Rekap.U3.BringToFront();
            }
            else
            {
                AturExpanded(true);
                AturButton(true);
                expandCollapsePanel1.IsExpanded = false;
                expandCollapsePanel2.IsExpanded = true;
                Rekap.U3.BringToFront();
            }
        }
        private void btnInput_Click(object sender, EventArgs e)
        {
            input i = new input();
            i.ShowDialog(this);
        }

        private void btnCabut_Click(object sender, EventArgs e)
        {
            cabut c = new cabut();
            c.ShowDialog(this);
        }

        private void btnDispose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.MinimizeBox = true;
        }
        private void TampilHasilIO()
        {
            Count.U1.TampilDataCalon0();
            Count.U1.TampilDataHistory();
            Count.U1.TotalSuara();
            Rekap.U3.TampilDataRekap();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Rekap u3 = new Rekap();
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
            printer.printDocument.DefaultPageSettings.Landscape = false;
            printer.PrintPreviewDataGridView(u3.dataGrid());
            printer.PrintDataGridView(u3.dataGrid());
        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            FrmLogin f0 = new FrmLogin();
            f0.Show();
            this.Close();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnCount_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.F2)
            {
                btnManage_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.F3)
            {
                btnRekap_Click(this, new EventArgs());
            }
        }
    }
}
