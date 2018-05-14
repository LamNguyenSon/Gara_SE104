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
	public partial class Phutung : Form
	{
		public void LayBangPT()
		{
			DATAPROVIDER kn = new DATAPROVIDER();
			DataTable dt = new DataTable();
			dt = kn.Executequery("select * from PHUTUNG");
			dataGridPhuTung.DataSource = dt;
		}
		public Phutung()
		{
			InitializeComponent();
		}

		private void cmdThem_Click(object sender, EventArgs e)
		{

		}

		private void cmdXoa_Click(object sender, EventArgs e)
		{

		}

		private void cmdSua_Click(object sender, EventArgs e)
		{

		}

		private void cmdThoat_Click(object sender, EventArgs e)
		{
			DialogResult dg = new DialogResult();
			dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dg == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void Phutung_Load(object sender, EventArgs e)
		{

		}

		private void cmdQuayLai_Click(object sender, EventArgs e)
		{
			LayBangPT();
		}
		public void LoadListByKeyWord()
		{
			DATAPROVIDER kn = new DATAPROVIDER();
			DataTable dt = new DataTable();
			dt = kn.Executequery("select * from PHUTUNG where Name like'%" + txtTimKiem.Text + "%' ");
			dataGridPhuTung.DataSource = dt;
		}

		private void cmdTimKiem_Click(object sender, EventArgs e)
		{
			LoadListByKeyWord();
		}

		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			LoadListByKeyWord();
		}
	}
}
