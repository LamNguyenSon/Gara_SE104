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

			if (txtMaPT.Text == "")
			{
				errorProvider1.SetError(txtMaPT, "Bạn chưa nhập MaPT");
			}
			if (txtMaBCT.Text == "")
			{
				errorProvider1.SetError(txtDonGia, "Bạn chưa nhập MaBCT ");
			}
			if (txtTenPhuTung.Text == "")
			{
				errorProvider1.SetError(txtMaBCT, "Bạn chưa nhập tên phụ tùng");
			}
			if (txtMaPT.Text != "" && txtDonGia.Text != "" && txtMaBCT.Text != "")
			{
				DATAPROVIDER kn = new DATAPROVIDER();

				int kq = kn.Executenonquery("insert into PHUTUNG(MAPT,MABCT,TENPHUTUNG,DONGIA,SOLUONG,NGAYNHAP) values('" + txtMaPT.Text + "','" + txtMaBCT.Text + "','" + txtTenPhuTung.Text + "','" + txtDonGia.Text + "','" + txtSoLuong.Text + "','" + dtNgayNhap.Text + "')");
				if (kq > 0)
				{
					MessageBox.Show("Thêm thành công");

					LayBangPT();
				}
				else
				{

					MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại");

				}
			}
		}

		private void cmdXoa_Click(object sender, EventArgs e)
		{
			if (txtMaPT.Text == "")
			{
				errorProvider1.SetError(txtMaPT, "Bạn chưa nhập MaPT");
			}
			if (txtMaBCT.Text == "")
			{
				errorProvider1.SetError(txtDonGia, "Bạn chưa nhập MaBCT ");
			}
			if (txtTenPhuTung.Text == "")
			{
				errorProvider1.SetError(txtMaBCT, "Bạn chưa nhập tên phụ tùng");
			}
			if (txtMaPT.Text != "" && txtDonGia.Text != "" && txtMaBCT.Text != "")
			{
				DATAPROVIDER kn = new DATAPROVIDER();
				int kq = kn.Executenonquery("delete from PHUTUNG where MaPT='" + txtMaPT.Text + "'");
				if (kq > 0)
				{

					MessageBox.Show("Xóa thành công");

					LayBangPT();
				}
				else
				{

					MessageBox.Show("Xóa không thành công, vui lòng kiểm tra lại");

				}
			}
		}

		private void cmdSua_Click(object sender, EventArgs e)
		{
			if (txtMaPT.Text == "")
			{
				errorProvider1.SetError(txtMaPT, "Bạn chưa nhập MaPT");
			}
			if (txtMaBCT.Text == "")
			{
				errorProvider1.SetError(txtDonGia, "Bạn chưa nhập MaBCT ");
			}
			if (txtTenPhuTung.Text == "")
			{
				errorProvider1.SetError(txtMaBCT, "Bạn chưa nhập tên phụ tùng");
			}
			if (txtMaPT.Text != "" && txtDonGia.Text != "" && txtMaBCT.Text != "")
			{
				DATAPROVIDER kn = new DATAPROVIDER();
				int kq = kn.Executenonquery("update PHUTUNG set TENPHUTUNG='" + txtTenPhuTung.Text + "', DONGIA='" + txtDonGia.Text + "',SOLUONG='" + txtSoLuong.Text + "',NGAYNHAP='" + dtNgayNhap.Text + "'");
				if (kq > 0)
				{
					MessageBox.Show("Sửa thành công");
					LayBangPT();
				}
				else
				{
					MessageBox.Show("Sửa không thành công, vui lòng kiểm tra lại");
				}
			}
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

			dt = kn.Executequery("select * from PHUTUNG where TENPHUTUNG like'%" + txtTimKiem.Text + "%' ");

			dataGridPhuTung.DataSource = dt;
		}

		private void cmdTimKiem_Click(object sender, EventArgs e)
		{
			LoadListByKeyWord();
		}



		private void txtTimKiem_TextChanged_1(object sender, EventArgs e)

		{
			LoadListByKeyWord();
		}

		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			LoadListByKeyWord();
		}

		private void dataGridPhuTung_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridViewRow row = new DataGridViewRow();

				row = dataGridPhuTung.Rows[e.RowIndex];
				txtMaPT.Text = row.Cells[0].Value.ToString();
				txtMaBCT.Text = row.Cells[1].Value.ToString();
				txtTenPhuTung.Text = row.Cells[2].Value.ToString();
				txtDonGia.Text = row.Cells[3].Value.ToString();
				txtSoLuong.Text = row.Cells[5].Value.ToString();
				dtNgayNhap.Text = row.Cells[6].Value.ToString();
			}
			catch
			{

			}
		}

		private void dataGridPhuTung_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridViewRow row = new DataGridViewRow();

				row = dataGridPhuTung.Rows[e.RowIndex];
				txtMaPT.Text = row.Cells[0].Value.ToString();
				txtMaBCT.Text = row.Cells[1].Value.ToString();
				txtTenPhuTung.Text = row.Cells[2].Value.ToString();
				txtDonGia.Text = row.Cells[3].Value.ToString();
				txtSoLuong.Text = row.Cells[5].Value.ToString();
				dtNgayNhap.Text = row.Cells[6].Value.ToString();
			}
			catch
			{

			}
		}
	}
}
