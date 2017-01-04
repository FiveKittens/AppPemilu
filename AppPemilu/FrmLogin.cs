using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing.Drawing2D;

namespace AppPemilu
{
    public partial class FrmLogin : Form
    {

        private Form1 f1;
        private Boolean status;
        private Entity.EntLogin login;
        private Interface.IntLogin LoginDao;
        public FrmLogin()
        {
            login = new Entity.EntLogin();
            LoginDao = Factory.FactLogin.GetInterfaceLogin();
            InitializeComponent();
            txtUsr.MaxLength = 5;
            txtPswd.MaxLength = 7;
        }
        private void txtPswd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMasuk_Click(this, new EventArgs());
            }
        }
        
        
        private void btnMasuk_Click(object sender, EventArgs e)
        {
            if (txtUsr.Text == "" || txtPswd.Text == "")
            {
                MessageBox.Show("Kode dan Password harus diisi !");
            }
            else
            {
                login.setKode(txtUsr.Text);
                login.setPassword(txtPswd.Text);
                status = LoginDao.Login(login);

                if (status == false)
                {
                    MessageBox.Show("Maaf login gagal");
                    txtUsr.Text = "";
                    txtPswd.Text = "";
                    txtUsr.Focus();
                }
                else
                {
                    f1 = new Form1();
                    f1.ShowDialog();
                    this.Hide();
                }
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtPswd.UseSystemPasswordChar = true;
            }
            else
            {
                txtPswd.UseSystemPasswordChar = false;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }
    }  
}