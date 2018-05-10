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
	public partial class QUẢN_LÝ_NHÂN_VIÊN : Form
	{

		public QUẢN_LÝ_NHÂN_VIÊN()
		{
			InitializeComponent();
		}
		public void LayBangNV()
		{
			ketnoi kn = new ketnoi();
			DataTable dt = new DataTable();
			dt = kn.laybang("select * from NHANVIEN");
			dataGridNhanVien.DataSource = dt;
		}
		
		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void QUẢN_LÝ_NHÂN_VIÊN_Load(object sender, EventArgs e)
		{
			LayBangNV();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			//if(txtMaNV.Text=="")
			//{
			//	ErrorProvider.Equals(txtMaNV, "Bạn chưa nhập Mã Nhân viên");
			//}
			//if(txtMaNV.Text!="")
			//{
			//	ketnoi kn = new ketnoi();
			//	int kq= kn.xulydulieu(Update NHANVIEN set MANV='""' )
			//}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			
		
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			
		}
		//public bool checkData()
		//{
		//	if(string.IsNullOrWhiteSpace(txtMaNV.Text))
		//	{
		//		MessageBox.Show("Bạn chưa nhập Mã Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		//		txtMaNV.Focus();
		//		return false;
		//	}
		//	if (string.IsNullOrWhiteSpace(txtHoTen.Text))
		//	{
		//		MessageBox.Show("Bạn chưa nhập Họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		//		txtHoTen.Focus();
		//		return false;
		//	}
		//	if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
		//	{
		//		MessageBox.Show("Bạn chưa nhập Địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		//		txtDiaChi.Focus();
		//		return false;
		//	}
		//	if (string.IsNullOrWhiteSpace(txtCMND.Text))
		//	{
		//		MessageBox.Show("Bạn chưa nhập CMND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		//		txtCMND.Focus();
		//		return false;
		//	}
		//	if (string.IsNullOrWhiteSpace(cbGioiTinh.Text))
		//	{
		//		MessageBox.Show("Bạn chưa nhập Giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		//		cbGioiTinh.Focus();
		//		return false;
		//	}
		//	return true;
		//}

		private void dataGridNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridViewRow row = new DataGridViewRow();
				row = dataGridNhanVien.Rows[e.RowIndex];
				txtMaNV.Text = row.Cells[0].Value.ToString();
				txtMaTK.Text = row.Cells[1].Value.ToString();
				txtHoTen.Text = row.Cells[2].Value.ToString();
				cbGioiTinh.Text = row.Cells[3].Value.ToString();
				dtNgaySinh.Text = row.Cells[4].Value.ToString();
				txtSDT.Text = row.Cells[5].Value.ToString();
				txtCMND.Text = row.Cells[6].Value.ToString();
				txtDiaChi.Text = row.Cells[7].Value.ToString();
			}
			catch
			{

			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult dt = new DialogResult();
			dt = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if(dt== DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridViewRow row = new DataGridViewRow();
				row = dataGridNhanVien.Rows[e.RowIndex];
				txtMaNV.Text = row.Cells[0].Value.ToString();
				txtMaTK.Text = row.Cells[1].Value.ToString();
				txtHoTen.Text = row.Cells[2].Value.ToString();
				cbGioiTinh.Text = row.Cells[3].Value.ToString();
				dtNgaySinh.Text = row.Cells[4].Value.ToString();
				txtSDT.Text = row.Cells[5].Value.ToString();
				txtCMND.Text = row.Cells[6].Value.ToString();
				txtDiaChi.Text = row.Cells[7].Value.ToString();
			}
			catch
			{

			}
		}
	}
	}

