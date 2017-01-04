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
    public partial class FrmInputSuara : Form
    {
        private string keterangan;
        private Entity.EntSuara suara;
        private Boolean hasil;
        private Interface.IntSuara suaraDao;
        public FrmInputSuara()
        {
            keterangan = "INSERT";
            suara = new Entity.EntSuara();
            suaraDao = Factory.FactLogin.GetInterfaceSuara();
            InitializeComponent();
        }

        public void AturText(Boolean status)
        {
            txtSuara.Enabled = status;
        }

        public void AturButton(Boolean status)
        {
            btnSubmit.Enabled = status;
            btnCancel.Enabled = status;
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            CenterToParent();
            txtSuara.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            suara.SetNomor(txtSuara.Text);

            if (keterangan == "INSERT")
            {
                hasil = suaraDao.tambahSuara(suara);
            }
            if (hasil == true)
            {
                this.Close();
            }
            else
            {
                this.Close();
            }
            AturText(false);
            AturButton(true);
        }

        private void txtSuara_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }
        private void txtSuara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }

        }
    }
}

