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
            string query = "SELECT PHUTUNG.MAPT AS N'Mã Phụ Tùng',TENPT AS N'Tên Phụ Tùng',SUM(SLPT_SUDUNG) AS N'Số Lượng Sử Dụng Trong Tháng',SOLUONG AS N'Số Lượng Còn Lại',SUM(THANHTIEN) AS'Tiền Thu' FROM dbo.THONGTINSUACHUA JOIN dbo.PHUTUNG ON PHUTUNG.MAPT = THONGTINSUACHUA.MAPT JOIN dbo.PHIEUSUACHUA ON PHIEUSUACHUA.MAPSC = THONGTINSUACHUA.MAPSC AND YEAR(NGAYSUACHUA)=YEAR(GETDATE()) AND MONTH(NGAYSUACHUA)=MONTH(GETDATE()) GROUP BY dbo.PHUTUNG.MAPT,dbo.PHUTUNG.TENPT,SOLUONG";
            DATAPROVIDER provider = new DATAPROVIDER();
            datagridbct.DataSource = provider.Executequery(query);

            query = "SELECT SUM(TIENTHU) as N'DOANHTHU' FROM dbo.PHIEUTHUTIEN WHERE YEAR(NGAYTHU)=YEAR(GETDATE()) AND MONTH(NGAYTHU)=MONTH(GETDATE())";
            ///////////////////////////
            DataTable tb = new DataTable();
            provider = new DATAPROVIDER();
            tb = provider.Executequery(query);
            foreach (DataRow row in tb.Rows)
            {
                string DT = row["DOANHTHU"].ToString();
                doanhthu.Text = DT;
                doanhthu.Show();


            }
        
        }

        private void doanhthu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
