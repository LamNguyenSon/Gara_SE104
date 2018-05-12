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
    public partial class QL_SUACHUA : Form
    {
        
        public QL_SUACHUA()
        {
            InitializeComponent();
            loadthongtinkhintocombobox();        
            loadloaiphutungcombobox();
        }
        void spilit_space(ref string str)
        {
            while (str[str.Length - 1] == ' ')

            {
                str = str.Remove(str.Length - 1);
            }
        }
        public void loadloaiphutungcombobox()
        {
            string query = "SELECT TENPT FROM dbo.PHUTUNG ";
            DATAPROVIDER provider = new DATAPROVIDER();
            DataTable tb = new DataTable();
            tb = provider.Executequery(query);
            foreach (DataRow row in tb.Rows)
            {
                string name = row["TENPT"].ToString();
                LOAIPT.Items.Add(name);
            }
            LOAIPT.Show();
        }
        public void loadthongtinMapsccombobox()
        {
            string query = "SELECT MAPSC FROM dbo.PHIEUSUACHUA JOIN dbo.KHACHHANG ON KHACHHANG.MAKH = PHIEUSUACHUA.MAKH AND HOTEN='" + hoten.Text.ToString() + "'";
            DATAPROVIDER provider = new DATAPROVIDER();
            DataTable tb = new DataTable();
            tb = provider.Executequery(query);
            foreach (DataRow row in tb.Rows)
            {
                string name = row["MAPSC"].ToString();
                MAPSC.Items.Add(name);
            }
            MAPSC.Show();
        }
        public void loadthongtinkhintocombobox()
        {
            string query = "SELECT *FROM dbo.KHACHHANG ";
            DATAPROVIDER provider = new DATAPROVIDER();
            DataTable tb = new DataTable();
            tb = provider.Executequery(query);
            foreach (DataRow row in tb.Rows)
            {
                string name = row["HOTEN"].ToString();
                tenkhachhang.Items.Add(name);
            }
            tenkhachhang.Show();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tenkhachhang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string query = "SELECT *FROM dbo.KHACHHANG WHERE HOTEN= '" + tenkhachhang.SelectedItem.ToString() + "'";
            DATAPROVIDER provider = new DATAPROVIDER();
            DataTable tb = new DataTable();
            tb = provider.Executequery(query);
            foreach (DataRow row in tb.Rows)
            {
                hoten.Text= row["HOTEN"].ToString();
                hoten.Show();

                cmnd.Text = row["CMND"].ToString();
                cmnd.Show();

                bienso.Text = row["BIENSO"].ToString();
                bienso.Show();

                loaixe.Text = row["LOAIXE"].ToString();
                loaixe.Show();

            }
            loadthongtinMapsccombobox();
        }

        private void LOAISC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LOAISC.SelectedItem.ToString() == "1.Sua Chua")
            {
                
                slptsd.Enabled = false;
                slptsd.Text = "0";
            }
            else
            {
                slptsd.Enabled = true;
            }

        }
        //kiểm tra sự tồn tại của  khóa chính trong  bảng thong tin sua chữa
        void loadthongtinsuachua(string mapt,string mapsc)
        {
            string query = "SELECT *FROM THONGTINSUACHUA WHERE MAPT='" + mapt + "' AND MAPSC= '" + mapsc + "'";
            DATAPROVIDER provider = new DATAPROVIDER();
            dataGridView1.DataSource = provider.Executequery(query);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string loai=null;
            if(LOAISC.SelectedItem.ToString()=="1.Sua Chua")
            {
                loai = "1";
            }
            else
            {
                loai = "2";
            }
            string maphieusc = MAPSC.SelectedItem.ToString();
            spilit_space(ref maphieusc);
            string tenpt = LOAIPT.SelectedItem.ToString();
            spilit_space(ref tenpt);



            string query = "SELECT MAPT FROM PHUTUNG WHERE TENPT='" + tenpt + "'";
            DATAPROVIDER provider = new DATAPROVIDER();
            DataTable tb = new DataTable();
            tb = provider.Executequery(query);
            string mapt = tb.Rows[0]["MAPT"].ToString();
            spilit_space(ref mapt);
            ////////////////////////////// kiểm tra sự tồn tại khóa chính
            query = "SELECT *FROM THONGTINSUACHUA WHERE MAPT='" + mapt + "' AND MAPSC= '" + maphieusc + "'";
            provider = new DATAPROVIDER();
            DataTable result = provider.Executequery(query);
            if(result.Rows.Count==1)
            {
                MessageBox.Show("Thông tin sửa chữa bị trùng !!!");
            }
            else
            {
                //////////////////////////////////
                query = "INSERT INTO dbo.THONGTINSUACHUA ( MAPT , MAPSC ,LOAISUACHUA ,MOTA ,SLPT_SUDUNG ,CHIPHI)VALUES  ( '" + mapt + "','" + maphieusc + "', " + loai + " ,N'" + MOTA.Text.ToString() + "' ," + slptsd.Text.ToString() + "," + CHIPHI.Text.ToString() + ")";
                tb = new DataTable();
                tb = provider.Executequery(query);
                loadthongtinsuachua(mapt,maphieusc);
                
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
