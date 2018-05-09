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
			ketnoi kn = new ketnoi();
			DataTable dt = new DataTable();
			dt = kn.laybang("select * from KHACHHANG");
			dataGridKhachHang.DataSource = dt;
		}
		public Khachhang()
		{
			InitializeComponent();
		}

		public void GetDSKH()
		{

		}

		private void Nhanvien_Load(object sender, EventArgs e)
		{
			LayBangKH();

		}

		private void Khachhang_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
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
				errorProvider1.SetError(txtDiaChi, "Bạn chưa nhập MaKH");
			}
			if (txtHoTen.Text == "")
			{
				errorProvider1.SetError(txtHoTen, "Bạn chưa nhập CMND");
			}
			if(txtMaKH.Text!=""&&txtDiaChi.Text!=""&&txtHoTen.Text!="")
			{
				ketnoi kn = new ketnoi();
				int kq=kn.xulydulieu("insert into KHACHHANG(MAKH,HOTEN,CMND,NGAYSINH,GIOITINH,DIACHI,SDT,BIENSO,LOAIXE) values('"+txtMaKH.Text+"','N"+txtHoTen.Text+ "','N" + txtCMND.Text + "','N" + dtNgaySinh.Text + "','N" + coboGioiTinh.Text + "','N" + txtDiaChi.Text + "','N" + txtBienSo.Text + "','N"+txtLoaiXe.Text+"')");
				if(kq>0)
				{
					MessageBox.Show("Thêm thành công");
				}
				else
				{
					MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại");
				}
			}
		}

		private void txtHoTen_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.SetError(txtMaKH, "");
		}

		private void txtMaKH_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.SetError(txtDiaChi, "");
		}

		private void txtCMND_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.SetError(txtHoTen, "");
		}

		private void comboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void txtDiaChi_TextChanged(object sender, EventArgs e)
		{

		}

		private void cmdSua_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
