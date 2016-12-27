using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid;

namespace AppPemilu
{
    public partial class Count : UserControl
    {
        private static Count u1;
        private Entity.EntSuara suara;
        private Interface.IntSuara suaraDao;
        public static Count U1
        {
            get
            {
                if (u1 == null)
                    u1 = new Count();
                return u1;
            }
        }

        public Count()
        {
            suara = new Entity.EntSuara();
            suaraDao = Factory.FactLogin.GetInterfaceSuara();
            InitializeComponent();
            TampilDataHistory();
            TotalSuara();
            TampilDataCalon();
            TampilDataCalon0();
        }

        public void TampilDataCalon()
        {
            DataSet data = new DataSet();
            data = suaraDao.SelectDetilCalon();
            gridCalon.DataSource = data.Tables["tb_vertical"];
            gridCalon.RetrieveFields();
            gridCalon.BestFit();
        }
        public void TampilDataCalon0()
        {
            DataSet data = new DataSet();
            data = suaraDao.SelectDetilCalon();
            gridControl1.DataSource = data.Tables["tb_vertical"];
        }
        public void TampilDataHistory()
        {
            DataSet data = new DataSet();
            data = suaraDao.SelectSuara();
            dgvHistory.DataSource = data.Tables["tb_suara"];
        }
        /*public void TampilDataCalon0()
         {
             DataSet data = new DataSet();
             data = suaraDao.SelectDetilCalon();
             dgvCln.DataSource = data.Tables["tb_count"];
             DataSet new_ds = FlipDataSet(data);
             DataView my_DataView = new DataView();
             my_DataView = new_ds.Tables["tb_calon"].DefaultView;
             dgvCln.DataSource = my_DataView;
         }
         public DataSet FlipDataSet(DataSet my_DataSet)
         {
             DataSet ds = new DataSet();

             foreach (DataTable dt in my_DataSet.Tables)
             {
                 DataTable table = new DataTable();

                 for (int i = 0; i <= dt.Rows.Count; i++)
                 { table.Columns.Add(Convert.ToString(i)); }

                 DataRow r;
                 for (int k = 0; k < dt.Columns.Count; k++)
                 {
                     r = table.NewRow();
                     r[0] = dt.Columns[k].ToString();
                     for (int j = 1; j <= dt.Rows.Count; j++)
                     { r[j] = dt.Rows[j - 1][k]; }
                     table.Rows.Add(r);
                 }
                 ds.Tables.Add(table);
             }

             return ds;
         }*/
        public Decimal TotalSuara()
        {
            decimal Total = 0;
            for (int i = 0; i < dgvHistory.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dgvHistory.Rows[i].Cells["suara_masuk"].Value);
            }
            txtTotal.Text = "   " + Total.ToString();
            return Total;
        }
        public DataGridView dataGrid()
        {
            return dgvHistory;
        }

        private void Count_Load(object sender, EventArgs e)
        {
            TampilDataCalon();
        }
    }
}
