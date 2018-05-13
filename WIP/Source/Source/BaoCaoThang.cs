using Source.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source
{
    public partial class BaoCaoThang : Form
    {
        public BaoCaoThang()
        {
            InitializeComponent();
            showdoanhthu();
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void showdoanhthu()
        {

            string query = "SELECT SUM(TIENTHU) as N'DOANHTHU' FROM dbo.PHIEUTHUTIEN WHERE YEAR(NGAYTHU)=YEAR(GETDATE()) AND MONTH(NGAYTHU)=MONTH(GETDATE())";
            ///////////////////////////
            DataTable tb = new DataTable();
            DATAPROVIDER provider = new DATAPROVIDER();
            tb = provider.Executequery(query);
            foreach (DataRow row in tb.Rows)
            {
                string DT = row["DOANHTHU"].ToString();
                doanhthu.Text = DT;
                doanhthu.Show();


            }
        
        }
    }
}
