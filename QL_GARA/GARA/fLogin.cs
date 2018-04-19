using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GARA
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Vào chương trình 
            FtableManager f = new FtableManager();
            this.Hide();
            f.ShowDialog();
            this.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //thoát chương trình
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hỏi người dùng có muốn thoát hay không
            if(MessageBox.Show("Bạn có thật sự muôn thoát chương trình không ?","Thông báo !",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
