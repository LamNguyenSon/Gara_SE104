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
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            loadaccount();
        }
        void spilit_space(ref string str)
        {
            while(str[str.Length-1]==' ')

            {
                str = str.Remove(str.Length - 1);
            }
        }
        void loadaccount()
        {
            string query = "SELECT *FROM dbo.TAIKHOAN";
            DATAPROVIDER provider = new DATAPROVIDER();
            DataTable tb = new DataTable();
            tb = provider.Executequery(query);
            string str = tb.Rows[0]["TENDN"].ToString();

            spilit_space(ref str);
            textboxtendangnhap.Text = str;
            textboxtendangnhap.Show();

            str = tb.Rows[0]["MATKHAU"].ToString();
            spilit_space(ref str);
            textBoxmatkhau.Text = str;
            textboxtendangnhap.Show();

            str = tb.Rows[0]["NGAYTAO"].ToString();
            spilit_space(ref str);
            textBoxngaytao.Text = str;
            textboxtendangnhap.Show();

        }
        void updatedata()
        {
            string query = "SELECT *FROM dbo.TAIKHOAN ";
            DATAPROVIDER provider = new DATAPROVIDER();
            DataTable tb = new DataTable();
            tb = provider.Executequery(query);
            string MATK = tb.Rows[0]["MATK"].ToString();
            spilit_space(ref MATK);
            ////////////////////////////
            //textBoxmatkhau.Text.ToString();

            query = "UPDATE dbo.TAIKHOAN SET TENDN= '" + textboxtendangnhap.Text.ToString() + "' , MATKHAU= '" + textBoxmatkhau.Text.ToString() + "' WHERE MATK= '" + MATK+"'";
            DATAPROVIDER pro = new DATAPROVIDER();
            DataTable tbable = new DataTable();
            tbable = pro.Executequery(query);

        }
            private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updatedata();
        }

        private void textBoxngaytao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
