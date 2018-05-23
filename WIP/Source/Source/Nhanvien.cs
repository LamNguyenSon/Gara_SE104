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
	public partial class Nhanvien : Form
	{
		public void LayBangNV()
		{
			DATAPROVIDER kn = new DATAPROVIDER();
			DataTable dt = new DataTable();
			dt = kn.Executequery("select * from NHANVIEN");
			dataGridNhanVien.DataSource = dt;
		}
		public Nhanvien()
		{
			InitializeComponent();
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

		private void cmdThem_Click(object sender, EventArgs e)
		{
			if (txtMaNV.Text == "")
			{
				errorProvider1.SetError(txtMaNV, "Bạn chưa nhập MaNV");
			}
			if (txtMaTK.Text == "")
			{
				errorProvider1.SetError(txtMaTK, "Bạn chưa nhập MaTK");
			}
			if (txtCMND.Text == "")
			{
				errorProvider1.SetError(txtCMND, "Bạn chưa nhập CMND");
			}
			if (txtHoTen.Text == "")
			{
				errorProvider1.SetError(txtHoTen, "Bạn chưa nhập họ tên");
			}
		}

		private void txtMaNV_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.SetError(txtMaNV, "");
		}

		private void txtMaTK_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.SetError(txtMaTK, "");
		}

		private void txtCMND_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.SetError(txtCMND, "");
		}

		private void txtDiaChi_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtHoTen_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.SetError(txtHoTen, "");
		}

		private void txtSDT_TextChanged(object sender, EventArgs e)
		{

		}

		private void dtNgaySinh_TextChanged(object sender, EventArgs e)
		{

		}

		private void coboGioiTinh_TextChanged(object sender, EventArgs e)
		{

		}

		private void cmdXoa_Click(object sender, EventArgs e)
		{

		}

		private void cmdSua_Click(object sender, EventArgs e)
		{

		}

		private void dtNgaySinh_ValueChanged(object sender, EventArgs e)
		{

		}

		private void coboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dataGridNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void NhanVien_Click(object sender, EventArgs e)
		{

		}

		private void NhanVien_Load(object sender, EventArgs e)
		{
			LayBangNV();
		}
	}
}
