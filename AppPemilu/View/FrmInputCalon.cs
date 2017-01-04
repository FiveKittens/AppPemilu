using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FrmLogin.View
{
    public partial class FrmInputCalon : Form
    {
        private string fileName;
        private Boolean hasil;
        private Entity.EntLogin login;
        private Interface.IntCalon clnDao;
        private Entity.EntCalon cln;
        
        public FrmInputCalon()
        {
            cln = new Entity.EntCalon();
            login = new Entity.EntLogin();
            clnDao = Factory.FactLogin.GetInterfaceCalon();
            InitializeComponent();
            AturText(false);
            AturButton(true);
        }
        
        public void AturText(Boolean status)
        {
            txtNama.Enabled = status;
            txtNomor.Enabled =! status;
            txtPartai.Enabled = status;
        }

        public void AturButton(Boolean status)
        {
            btnSubmit.Enabled = status;
            btnKeluar.Enabled = status;
            btnDefault.Enabled = status;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            View.FrmDashboard f4 = new View.FrmDashboard();
            f4.ShowDialog();
            this.Dispose();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            label7.Text = login.getID();
            label5.Text = login.getUser();
            txtNomor.Text = clnDao.nomorBaru();
            txtNama.Text = "";
            txtPartai.Text = "";
            txtNama.Focus();
            AturText(true);
            AturButton(true);
        }
        private byte[] ImagePic()
        {
            byte[] img = null;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            return img;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            cln.SetNomor(txtNomor.Text);
            cln.SetNama(txtNama.Text);
            cln.SetPartai(txtPartai.Text);
            cln.SetImage(ImagePic());            
            
                hasil = clnDao.submitCalon(cln);
            

            if (hasil == true)
            {
                MessageBox.Show("Data berhasil disimpan");
            }
            else
            {
                MessageBox.Show("Penyimpanan data gagal");
            }

            AturText(true);
            AturButton(true);
            txtNama.Clear();
            txtPartai.Clear();
            txtNomor.Text = clnDao.nomorBaru();
            txtNama.Focus();
        }
        byte[] ConvertimageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


        private void btnBrowse_Click(object sender, EventArgs e)
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
                    pictureBox2.ImageLocation = fileName;
                    pictureBox2.Image = Image.FromFile(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EROR" + ex);
            }
        }
       
    }
}
