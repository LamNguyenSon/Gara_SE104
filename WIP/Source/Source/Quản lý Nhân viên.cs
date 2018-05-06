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
		string flag;
		DataTable dtNV;

		public QUẢN_LÝ_NHÂN_VIÊN()
		{
			InitializeComponent();
		}
		public DataTable createTable()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("MaNV");
			dt.Columns.Add("HoTen");
			dt.Columns.Add("DiaChi");
			dt.Columns.Add("CMND");
			dt.Columns.Add("GioiTinh");
			return dt;
		}
		public void KhoaControl()
		{
			btnThem.Enabled = true;
			btnCapNhat.Enabled = true;
			btnXoa.Enabled = true;
			btnLuu.Enabled = false;
			btnThoat.Enabled = false;

			txtMaNV.ReadOnly = true;
			txtHoTen.ReadOnly = true;
			txtDiaChi.ReadOnly = true;
			txtCMND.ReadOnly = true;
			cbGioiTinh.Enabled= false;

			btnThem.Focus();
		}
		private void MoControl()
		{
			btnThem.Enabled = false;
			btnCapNhat.Enabled = false;
			btnXoa.Enabled = false;
			btnLuu.Enabled = true;
			btnThoat.Enabled = true;

			txtMaNV.ReadOnly = false;
			txtHoTen.ReadOnly = false;
			txtDiaChi.ReadOnly = false;
			txtCMND.ReadOnly = false;
			cbGioiTinh.Enabled = true;

			txtMaNV.Focus();
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
			KhoaControl();
			dtNV = createTable();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			MoControl();
			flag = "add";
			txtMaNV.Text = "";
			txtHoTen.Text = "";
			txtDiaChi.Text = "";
			txtCMND.Text = "";
			cbGioiTinh.Text = "";

		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			MoControl();
			flag = "edit";
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			MoControl();
			flag = "delete";
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			if(flag=="add")
			{
				if(checkData())
				{
					dtNV.Rows.Add(txtMaNV.Text, txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, cbGioiTinh.Text);
					dataGridNhanVien.DataSource = dtNV;
					dataGridNhanVien.RefreshEdit();
				}
				KhoaControl();
			}
		}
		public bool checkData()
		{
			if(string.IsNullOrWhiteSpace(txtMaNV.Text))
			{
				MessageBox.Show("Bạn chưa nhập Mã Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtMaNV.Focus();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtHoTen.Text))
			{
				MessageBox.Show("Bạn chưa nhập Họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtHoTen.Focus();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
			{
				MessageBox.Show("Bạn chưa nhập Địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtDiaChi.Focus();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtCMND.Text))
			{
				MessageBox.Show("Bạn chưa nhập CMND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtCMND.Focus();
				return false;
			}
			if (string.IsNullOrWhiteSpace(cbGioiTinh.Text))
			{
				MessageBox.Show("Bạn chưa nhập Giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				cbGioiTinh.Focus();
				return false;
			}
			return true;
		}
		public void dataGridNhanVien_SelectionChanged(object sender, EventArgs e)
		{
			int index = dataGridNhanVien.CurrentCell.RowIndex;
			DataTable dt = (DataTable)dataGridNhanVien.DataSource;
			if(dt.Rows.Count > 0)
			{
				txtMaNV.Text = dataGridNhanVien.Rows[index].Cells[0].Value.ToString();
				txtHoTen.Text = dataGridNhanVien.Rows[index].Cells[1].Value.ToString();
				txtDiaChi.Text = dataGridNhanVien.Rows[index].Cells[2].Value.ToString();
				txtCMND.Text = dataGridNhanVien.Rows[index].Cells[3].Value.ToString();
				cbGioiTinh.Text = dataGridNhanVien.Rows[index].Cells[4].Value.ToString();
			}
		}
	}
}
