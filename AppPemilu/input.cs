using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPemilu
{
    public partial class input : Form
    {
        private Entity.EntSuara suara;
        private Boolean hasil;
        private Interface.IntSuara suaraDao;
        public input()
        {
            suara = new Entity.EntSuara();
            suaraDao = Factory.FactLogin.GetInterfaceSuara();
            InitializeComponent();
            CenterToScreen();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            suara.SetNomor(txtSuara.Text);
                        
            hasil = suaraDao.tambahSuara(suara);
            Count.U1.TampilDataCalon0();
            Count.U1.TampilDataHistory();
            Count.U1.TotalSuara();
            Rekap.U3.TampilDataRekap();
            txtSuara.Clear();
        }
        public void TampilDataHistory()
        {
            Count u1 = new Count();
            DataSet data = new DataSet();
            data = suaraDao.SelectSuara();
            u1.dataGrid().DataSource = data.Tables["tb_suara"];
        }
        public void TampilDataRekap()
        {
            Rekap u3 = new Rekap();
            DataSet data = new DataSet();
            data = suaraDao.RekapSuara();
            u3.dataGrid().DataSource = data.Tables["tb_rekap"];
            u3.dataGrid().Sort(u3.dataGrid().Columns["waktu_suara"], ListSortDirection.Ascending);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void input_Load(object sender, EventArgs e)
        {
            
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
        private void txtSuara_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnClose_Click(this, new EventArgs());
            }
        }
        private void input_Activated(object sender, EventArgs e)
        {
            txtSuara.Focus();
        }
    }
}
