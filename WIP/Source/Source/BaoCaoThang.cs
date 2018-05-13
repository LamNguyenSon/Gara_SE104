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
            showbct();
        }
        void showbct()
        {
            string query = "SELECT PHUTUNG.MAPT AS N'Mã Phụ Tùng' ,TENPT AS N'Tên Phụ Tùng',SUM(SLPT_SUDUNG) as N'Số Lượng Phụ Tùng Sử Dụng Trong Tháng',sum(CHIPHI) AS N'Chi Phí' FROM dbo.PHUTUNG JOIN dbo.THONGTINSUACHUA ON THONGTINSUACHUA.MAPT = PHUTUNG.MAPT GROUP BY PHUTUNG.MAPT,TENPT";
            DATAPROVIDER provider = new DATAPROVIDER();
            dataGridView1.DataSource = provider.Executequery(query);
            query = "SELECT SUM(TIENTHU) as N'DOANHTHU' FROM dbo.PHIEUTHUTIEN ";
            ///////////////////////////
            DataTable tb = new DataTable();
            tb = provider.Executequery(query);
            foreach (DataRow row in tb.Rows)
            {
                doanhthu.Text = row["DOANHTHU"].ToString();
                doanhthu.Show();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "SELECT *FROM dbo.BAOCAOTHANG WHERE MABCT= '" + MaBCT.Text.ToString() + "'";
            DATAPROVIDER provider = new DATAPROVIDER();
            DataTable result = provider.Executequery(query);
            int n = result.Rows.Count;
            if (MaBCT.Text == "")
            {
                MessageBox.Show("Mã Báo Cáo Tháng Không Được Trống !");
            }
            else if(n==1)
            {
                MessageBox.Show("Mã Báo Cáo Tháng Đã Tồn Tại !");
            }
            else
            {
                query = "SELECT SUM(TIENTHU) as N'DOANHTHU' FROM dbo.PHIEUTHUTIEN";
                ///////////////////////////
                DataTable tb = new DataTable();
                tb = provider.Executequery(query);
                foreach (DataRow row in tb.Rows)
                {
                    string DT = row["DOANHTHU"].ToString();
                    query = "INSERT INTO dbo.BAOCAOTHANG ( MABCT, DOANHTHU, NGAYLAP ) VALUES  ('"+MaBCT.Text+"',"+DT+",GETDATE() )";
                    tb = provider.Executequery(query);
                    MessageBox.Show("In Báo Cáo Tháng Tháng Công !");
                    

                }
            }
        }
    }
}
