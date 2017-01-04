using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppPemilu
{
    public partial class Manage : UserControl
    {
        private static Manage u2;
        string fileName;
        private DataSet data;
        private Entity.EntCalon calon;
        private Interface.IntCalon calonDao;
        public static Manage U2
        {
            get
            {
                if (u2 == null)
                    u2 = new Manage();
                return u2;
            }
        }
        public Manage()
        {
            calon = new Entity.EntCalon();
            calonDao = Factory.FactLogin.GetInterfaceCalon();
            InitializeComponent();
            TampilDataCalon();
            AturText0(true);
            txtNomor0.Text = calonDao.nomorBaru();
        }

        public void AturText0(Boolean status)
        {
            txtNomor0.Enabled =! status;
            txtNama0.Enabled = status;
            txtPartai0.Enabled = status;
        }

        public void TampilDataCalon()
        {
            try
            {
                data = new DataSet();
                data = calonDao.SelectCalon();
                dgvCalon1.DataSource = data.Tables["tb_calon"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror " + ex);
            }
        }

        byte[] ConvertimageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private byte[] ImagePic()
        {
            byte[] img = null;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            return img;
        }
        private void pictureBox0_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = "C:\\";
                open.Filter = "Image File(*.jpg)|*.jpg|(*.png)|*.png|All Files(*.*)|*.*";
                open.FilterIndex = 1;
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fileName = open.FileName.ToString();
                    pictureBox0.ImageLocation = fileName;
                    pictureBox0.Image = Image.FromFile(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EROR" + ex);
            }
        }

        private void pbCalon1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = "C:\\";
                open.Filter = "Image File(*.jpg)|*.jpg|(*.png)|*.png|All Files(*.*)|*.*";
                open.FilterIndex = 1;
                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fileName = open.FileName.ToString();
                    label1.Text = fileName;
                    pbCalon1.ImageLocation = fileName;
                    pbCalon1.Image = Image.FromFile(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EROR" + ex);
            }
        }

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            calon.SetNomor(txtNomor1.Text);
            calon.SetNama(txtNama1.Text);
            calon.SetPartai(txtPartai1.Text);
            if (pbCalon1.Image == null)
            {
                MessageBox.Show("Pilih Gambar Terlebih Dahulu");
            }
            else
            {
                calon.SetImage(ImagePic());
            }
            calonDao.updateCalon(calon);
            TampilDataCalon();
        }

        private void btnSubmit0_Click(object sender, EventArgs e)
        {
            if (txtNama0.Text == "" || txtPartai0.Text == "" || (txtNama0.Text == "" && txtPartai0.Text == ""))
            {
                MessageBox.Show("Mohon Lengkapi Data");
            }
            else
            {
                calon.SetNomor(txtNomor0.Text);
                calon.SetNama(txtNama0.Text);
                calon.SetPartai(txtPartai0.Text);
            }
            if (pictureBox0.Image == null)
            {
                MessageBox.Show("Pilih Gambar Terlebih Dahulu");
            }
            else
            {
                calon.SetImage(ImagePic());
            }

            calonDao.submitCalon(calon);
            TampilDataCalon();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab == this.tabPage1)
            {
                tabPage1.Controls.Add(dgvCalon1);
            }
            else
            {
                tabPage2.Controls.Add(dgvCalon1);
            }
            // add the dataGridView1 onto the current tab page
            /*this.tabControl1.SelectedTab.Controls.Add(this.dataGridView1);*/
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            tabPage1.Controls.Add(dgvCalon1);
        }

        private void dgvCalon1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvCalon1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtNomor1.Text = row.Cells[0].Value.ToString();
                txtNama1.Text = row.Cells[1].Value.ToString();
                txtPartai1.Text = row.Cells[2].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])row.Cells[3].Value);
                pbCalon1.Image = Image.FromStream(ms);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            calon.SetNomor(txtNomor1.Text);

            calonDao.deleteCalon(calon);
            TampilDataCalon();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
