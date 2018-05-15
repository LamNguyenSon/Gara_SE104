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
// sửa namspace ->quick actions
namespace Source
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
            string username = textusername.Text;
            string password = textpassword.Text;
			if (login(username, password))
			{
				Home_page f = new Home_page();
				this.Hide();
				f.ShowDialog();
				this.Show();
<<<<<<< HEAD
			}
			else
			{
				MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !");
			}


		}
		bool login(string username, string password)
=======
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !");
            }


        }
            bool login(string username, string password)
>>>>>>> 4fe023875b0b49133466e341884611d9ec8caddd
		{
			accountDAO acc = new accountDAO();
			return acc.login(username,password);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
