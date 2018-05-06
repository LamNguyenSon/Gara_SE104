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
    public partial class Home_page : Form
    {
        public Home_page()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

		private void button2_Click(object sender, EventArgs e)
		{
			QUẢN_LÝ_NHÂN_VIÊN f = new QUẢN_LÝ_NHÂN_VIÊN();
			this.Hide();
			f.ShowDialog();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			PHIẾU_THU_TIỀN f = new PHIẾU_THU_TIỀN();
			this.Hide();
			f.ShowDialog();
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
