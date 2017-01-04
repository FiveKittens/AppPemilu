using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AppPemilu
{
    public partial class Koneksi_manager : Form
    {        
        public Koneksi_manager()
        {
            InitializeComponent();
            AturButtonTeks();
        }
        private void AturButtonTeks()
        {
            btnSubmit.Enabled = true;
            btnClose.Enabled = true;
            txtDBUser.Enabled = false;
            txtDBPassword.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;", cboItem.Text, txtDBName.Text);
            try
            {
                KoneksiDB.Koneksi conn = new KoneksiDB.Koneksi(connectionString);
                if (conn.IsConnection)
                {
                    MessageBox.Show("Koneksi sukses", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmLogin f0 = new FrmLogin();
                    f0.Show();
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=SSPI;", cboItem.Text, txtDBName.Text);
            try
            {
                KoneksiDB.Koneksi conn = new KoneksiDB.Koneksi(connectionString);
                if (conn.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.saveConfigString("db_pemilu", connectionString);
                    MessageBox.Show("Save Config Sukses", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Koneksi_manager_Load(object sender, EventArgs e)
        {
            PilihServer();
        }
        private void PilihServer()
        {
            cboItem.Items.Add(".");
            cboItem.Items.Add("local");
            cboItem.Items.Add(@".\SQLEXPRESS");
            cboItem.Items.Add(string.Format(@"{0}", Environment.MachineName));
            cboItem.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cboItem.SelectedIndex = 3;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
