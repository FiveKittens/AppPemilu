using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPemilu
{
    public partial class Rekap : UserControl
    {
        private DataSet data;
        private Timer time;
        private static Rekap u3;
        private Interface.IntSuara suaraDao;
        public static Rekap U3
        {
            get
            {
                if (u3 == null)
                    u3 = new Rekap();
                return u3;
            }
        }
        public Rekap()
        {
            time = new Timer();
            suaraDao = Factory.FactLogin.GetInterfaceSuara();
            InitializeComponent();
            TampilDataRekap();
            JamAsik();
        }
        private void JamAsik()
        {
            time.Interval = 1000;
            time.Tick += new EventHandler(this.Time_Tick);
            time.Start();
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
        public void TampilDataRekap()
        {
            data = new DataSet();
            data = suaraDao.RekapSuara();
            dgvRekap.DataSource = data.Tables["tb_rekap"];
            this.dgvRekap.Sort(this.dgvRekap.Columns["waktu_suara"], ListSortDirection.Ascending);
        }
        public DataGridView dataGrid()
        {
            return dgvRekap;
        }
    }
}
