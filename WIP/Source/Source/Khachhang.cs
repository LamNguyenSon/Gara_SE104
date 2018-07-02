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

namespace Source.Resources
{
	public partial class Khachhang : Form
	{
		public void LayBangKH()
		{
			DATAPROVIDER kn = new DATAPROVIDER();
			DataTable dt = new DataTable();
			dt = kn.Executequery("select * from KHACHHANG");
			dataGridKhachHang.DataSource = dt;
		}
		public Khachhang()
		{
			InitializeComponent();
		}

		public void GetDSKH()
		{

		}

		private void Khachhang_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void cmdThoat_Click(object sender, EventArgs e)
		{
			DialogResult dg = new DialogResult();
			dg =MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(dg == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void cmdThem_Click(object sender, EventArgs e)
		{
			if (txtMaKH.Text == "")
			{
				errorProvider1.SetError(txtMaKH, "Bạn chưa nhập tên");
			}
			if (txtDiaChi.Text == "")
			{
				errorProvider1.SetError(txtDiaChi, "Bạn chưa nhập DiaChi");
			}
			if (txtHoTen.Text == "")
			{
				errorProvider1.SetError(txtHoTen, "Bạn chưa nhập CMND");
			}
			if(txtMaKH.Text!=""&&txtDiaChi.Text!=""&&txtHoTen.Text!="")
			{
				DATAPROVIDER kn = new DATAPROVIDER();
				int kq = kn.Executenonquery("insert into KHACHHANG(MAKH,HOTEN,CMND,NGAYSINH,GIOITINH,DIACHI,SDT,BIENSO,LOAIXE) values('" + txtMaKH.Text + "','N" + txtHoTen.Text + "','N" + txtCMND.Text + "','N" + dtNgaySinh.Text + "','N" + coboGioiTinh.Text + "','N" + txtDiaChi.Text + "','N" + txtSDT.Text + "','N" + txtBienSo.Text + "','N" + txtLoaiXe.Text + "')");
				if (kq > 0)
				{
					MessageBox.Show("Thêm thành công");
					LayBangKH();
				}
				else
				{
					MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại");
				}
			}
		}

		private void txtHoTen_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.SetError(txtHoTen, "");
		}

		private void txtMaKH_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.SetError(txtMaKH, "");
			
		}

		private void txtCMND_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.SetError(txtCMND, "");
		}

		private void comboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void txtDiaChi_TextChanged(object sender, EventArgs e)
		{

		}

		private void cmdSua_Click(object sender, EventArgs e)
		{
			if (txtMaKH.Text == "")
			{
				errorProvider1.SetError(txtMaKH, "Bạn chưa nhập tên");
			}
			if (txtDiaChi.Text == "")
			{
				errorProvider1.SetError(txtDiaChi, "Bạn chưa nhập DiaChi");
			}
			if (txtHoTen.Text == "")
			{
				errorProvider1.SetError(txtHoTen, "Bạn chưa nhập CMND");
			}
			if (txtMaKH.Text != "" && txtDiaChi.Text != "" && txtHoTen.Text != "")
			{
				DATAPROVIDER kn = new DATAPROVIDER();
				int kq = kn.Executenonquery("update KHACHHANG set HOTEN='"+txtHoTen.Text+"', CMND='"+txtCMND.Text+ "',NGAYSINH='" +dtNgaySinh.Text+ "', GIOITINH='" + coboGioiTinh.Text + "',DIACHI='" + txtDiaChi.Text+ "',SDT='" + txtSDT.Text + "',BIENSO='" + txtBienSo.Text + "',LOAIXE='" + txtLoaiXe.Text + "' where MAKH='"+txtMaKH.Text+"'");
				if (kq > 0)
				{
					MessageBox.Show("Sửa thành công");
					LayBangKH();
				}
				else
				{
					MessageBox.Show("Sửa không thành công, vui lòng kiểm tra lại");
				}
			}
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void cmdXoa_Click(object sender, EventArgs e)
		{
			if (txtMaKH.Text == "")
			{
				errorProvider1.SetError(txtMaKH, "Bạn chưa nhập tên");
			}
			if (txtDiaChi.Text == "")
			{
				errorProvider1.SetError(txtDiaChi, "Bạn chưa nhập DiaChi");
			}
			if (txtHoTen.Text == "")
			{
				errorProvider1.SetError(txtHoTen, "Bạn chưa nhập CMND");
			}
			if (txtMaKH.Text != "" && txtDiaChi.Text != "" && txtHoTen.Text != "")
			{
				DATAPROVIDER kn = new DATAPROVIDER();
				int kq = kn.Executenonquery("delete from KHACHHANG where MaKH='"+txtMaKH.Text+"'");
				if (kq > 0)
				{
					MessageBox.Show("Xóa thành công");
					LayBangKH();
				}
				else
				{
					MessageBox.Show("Xóa không thành công, vui lòng kiểm tra lại");
				}
			}
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter_1(object sender, EventArgs e)
		{

		}

		private void txtSDT_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtBienSo_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtLoaiXe_TextChanged(object sender, EventArgs e)
		{

		}

		private void KachHang_Load(object sender, EventArgs e)
		{
			LayBangKH();
		}
		
		public void LoadListByKeyWord()
		{
			DATAPROVIDER kn = new DATAPROVIDER();
			DataTable dt = new DataTable();
			dt = kn.Executequery("select * from KHACHHANG where Name like'%"+txtTimKiem.Text+"%' ");
			dataGridKhachHang.DataSource = dt;
		}

		private void dataGridKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridViewRow row = new DataGridViewRow();

				row = dataGridKhachHang.Rows[e.RowIndex];
				txtMaKH.Text = row.Cells[0].Value.ToString();
				txtHoTen.Text = row.Cells[1].Value.ToString();
				coboGioiTinh.Text = row.Cells[2].Value.ToString();
				dtNgaySinh.Text = row.Cells[3].Value.ToString();
				txtSDT.Text = row.Cells[4].Value.ToString();
				txtCMND.Text = row.Cells[5].Value.ToString();
				txtDiaChi.Text = row.Cells[6].Value.ToString();
				txtBienSo.Text = row.Cells[7].Value.ToString();
				txtLoaiXe.Text = row.Cells[8].Value.ToString();
			}
			catch
			{

			}
		

		}

		private void dataGridKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			try
			{
				DataGridViewRow row = new DataGridViewRow();

				row = dataGridKhachHang.Rows[e.RowIndex];
				txtMaKH.Text = row.Cells[0].Value.ToString();
				txtHoTen.Text = row.Cells[1].Value.ToString();
				coboGioiTinh.Text = row.Cells[2].Value.ToString();
				dtNgaySinh.Text = row.Cells[3].Value.ToString();
				txtSDT.Text = row.Cells[4].Value.ToString();
				txtCMND.Text = row.Cells[5].Value.ToString();
				txtDiaChi.Text = row.Cells[6].Value.ToString();
				txtBienSo.Text = row.Cells[7].Value.ToString();
				txtLoaiXe.Text = row.Cells[8].Value.ToString();
			}
			catch
			{

			}
		}

		private void cmdTimKiem_Click(object sender, EventArgs e)
		{
			LoadListByKeyWord();
		}

		private void cmdQuayLai_Click(object sender, EventArgs e)
		{
			LayBangKH();
		}

		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			LoadListByKeyWord();
		}
	}
}

