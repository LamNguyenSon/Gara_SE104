namespace Source
{
	partial class Nhanvien
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtMaTK = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.cmdXoa = new System.Windows.Forms.Button();
			this.cmdSua = new System.Windows.Forms.Button();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.coboGioiTinh = new System.Windows.Forms.ComboBox();
			this.cmdThoat = new System.Windows.Forms.Button();
			this.cmdThem = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.txtCMND = new System.Windows.Forms.TextBox();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridNhanVien = new System.Windows.Forms.DataGridView();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.cmdTimKiem = new System.Windows.Forms.Button();
			this.cmdQuayLai = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridNhanVien)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtMaTK);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.dtNgaySinh);
			this.groupBox1.Controls.Add(this.cmdXoa);
			this.groupBox1.Controls.Add(this.cmdSua);
			this.groupBox1.Controls.Add(this.txtSDT);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtDiaChi);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.coboGioiTinh);
			this.groupBox1.Controls.Add(this.cmdThoat);
			this.groupBox1.Controls.Add(this.cmdThem);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtHoTen);
			this.groupBox1.Controls.Add(this.txtCMND);
			this.groupBox1.Controls.Add(this.txtMaNV);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(18, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(747, 259);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "CẬP NHẬT NHÂN VIÊN";
			// 
			// txtMaTK
			// 
			this.txtMaTK.Location = new System.Drawing.Point(111, 64);
			this.txtMaTK.Name = "txtMaTK";
			this.txtMaTK.Size = new System.Drawing.Size(236, 29);
			this.txtMaTK.TabIndex = 30;
			this.txtMaTK.TextChanged += new System.EventHandler(this.txtMaTK_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 74);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 19);
			this.label7.TabIndex = 29;
			this.label7.Text = "Mã TK";
			// 
			// dtNgaySinh
			// 
			this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtNgaySinh.Location = new System.Drawing.Point(480, 110);
			this.dtNgaySinh.Name = "dtNgaySinh";
			this.dtNgaySinh.Size = new System.Drawing.Size(134, 29);
			this.dtNgaySinh.TabIndex = 7;
			this.dtNgaySinh.ValueChanged += new System.EventHandler(this.dtNgaySinh_ValueChanged);
			// 
			// cmdXoa
			// 
			this.cmdXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdXoa.Location = new System.Drawing.Point(260, 215);
			this.cmdXoa.Name = "cmdXoa";
			this.cmdXoa.Size = new System.Drawing.Size(86, 45);
			this.cmdXoa.TabIndex = 28;
			this.cmdXoa.Text = "Xóa";
			this.cmdXoa.UseVisualStyleBackColor = true;
			this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click_1);
			// 
			// cmdSua
			// 
			this.cmdSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdSua.Location = new System.Drawing.Point(480, 214);
			this.cmdSua.Name = "cmdSua";
			this.cmdSua.Size = new System.Drawing.Size(86, 45);
			this.cmdSua.TabIndex = 27;
			this.cmdSua.Text = "Sửa";
			this.cmdSua.UseVisualStyleBackColor = true;
			this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click_1);
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(480, 24);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(236, 29);
			this.txtSDT.TabIndex = 26;
			this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(399, 34);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 19);
			this.label10.TabIndex = 23;
			this.label10.Text = "SDT";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(480, 64);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(236, 29);
			this.txtDiaChi.TabIndex = 19;
			this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 34);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 19);
			this.label6.TabIndex = 18;
			this.label6.Text = "Mã NV";
			// 
			// coboGioiTinh
			// 
			this.coboGioiTinh.FormattingEnabled = true;
			this.coboGioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ",
            "Khác"});
			this.coboGioiTinh.Location = new System.Drawing.Point(480, 150);
			this.coboGioiTinh.Name = "coboGioiTinh";
			this.coboGioiTinh.Size = new System.Drawing.Size(134, 30);
			this.coboGioiTinh.TabIndex = 17;
			this.coboGioiTinh.Text = "Nam ";
			this.coboGioiTinh.SelectedIndexChanged += new System.EventHandler(this.coboGioiTinh_SelectedIndexChanged);
			// 
			// cmdThoat
			// 
			this.cmdThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdThoat.Location = new System.Drawing.Point(630, 214);
			this.cmdThoat.Name = "cmdThoat";
			this.cmdThoat.Size = new System.Drawing.Size(86, 45);
			this.cmdThoat.TabIndex = 16;
			this.cmdThoat.Text = "Thoát";
			this.cmdThoat.UseVisualStyleBackColor = true;
			this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
			// 
			// cmdThem
			// 
			this.cmdThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdThem.Location = new System.Drawing.Point(111, 215);
			this.cmdThem.Name = "cmdThem";
			this.cmdThem.Size = new System.Drawing.Size(86, 45);
			this.cmdThem.TabIndex = 15;
			this.cmdThem.Text = "Thêm";
			this.cmdThem.UseVisualStyleBackColor = true;
			this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(399, 161);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 19);
			this.label5.TabIndex = 9;
			this.label5.Text = "Giới Tính";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(399, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 19);
			this.label4.TabIndex = 8;
			this.label4.Text = "Ngày Sinh";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(399, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "Địa Chỉ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "CMND";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 117);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "Họ Tên";
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(110, 107);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(236, 29);
			this.txtHoTen.TabIndex = 3;
			this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
			// 
			// txtCMND
			// 
			this.txtCMND.Location = new System.Drawing.Point(111, 151);
			this.txtCMND.Name = "txtCMND";
			this.txtCMND.Size = new System.Drawing.Size(236, 29);
			this.txtCMND.TabIndex = 2;
			this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
			// 
			// txtMaNV
			// 
			this.txtMaNV.Location = new System.Drawing.Point(110, 24);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(236, 29);
			this.txtMaNV.TabIndex = 0;
			this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridNhanVien);
			this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(18, 327);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(747, 158);
			this.groupBox3.TabIndex = 17;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "DANH SÁCH NHÂN VIÊN";
			// 
			// dataGridNhanVien
			// 
			this.dataGridNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridNhanVien.Location = new System.Drawing.Point(6, 28);
			this.dataGridNhanVien.Name = "dataGridNhanVien";
			this.dataGridNhanVien.Size = new System.Drawing.Size(729, 145);
			this.dataGridNhanVien.TabIndex = 0;
			this.dataGridNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNhanVien_CellClick);
			this.dataGridNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNhanVien_CellContentClick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// errorProvider2
			// 
			this.errorProvider2.ContainerControl = this;
			// 
			// errorProvider3
			// 
			this.errorProvider3.ContainerControl = this;
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(18, 301);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(248, 20);
			this.txtTimKiem.TabIndex = 18;
			this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
			// 
			// cmdTimKiem
			// 
			this.cmdTimKiem.Location = new System.Drawing.Point(279, 301);
			this.cmdTimKiem.Name = "cmdTimKiem";
			this.cmdTimKiem.Size = new System.Drawing.Size(86, 23);
			this.cmdTimKiem.TabIndex = 19;
			this.cmdTimKiem.Text = "Tìm kiếm";
			this.cmdTimKiem.UseVisualStyleBackColor = true;
			this.cmdTimKiem.Click += new System.EventHandler(this.cmdTimKiem_Click);
			// 
			// cmdQuayLai
			// 
			this.cmdQuayLai.Location = new System.Drawing.Point(382, 298);
			this.cmdQuayLai.Name = "cmdQuayLai";
			this.cmdQuayLai.Size = new System.Drawing.Size(127, 23);
			this.cmdQuayLai.TabIndex = 20;
			this.cmdQuayLai.Text = "Quay lại danh sách";
			this.cmdQuayLai.UseVisualStyleBackColor = true;
			this.cmdQuayLai.Click += new System.EventHandler(this.cmdQuayLai_Click);
			// 
			// Nhanvien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 524);
			this.Controls.Add(this.cmdQuayLai);
			this.Controls.Add(this.cmdTimKiem);
			this.Controls.Add(this.txtTimKiem);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Name = "Nhanvien";
			this.Text = "Nhanvien";
			this.Load += new System.EventHandler(this.NhanVien_Load);
			this.Click += new System.EventHandler(this.NhanVien_Click);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridNhanVien)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button cmdXoa;
		private System.Windows.Forms.Button cmdSua;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox coboGioiTinh;
		private System.Windows.Forms.Button cmdThoat;
		private System.Windows.Forms.Button cmdThem;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtNgaySinh;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.TextBox txtCMND;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridNhanVien;
		private System.Windows.Forms.TextBox txtMaTK;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ErrorProvider errorProvider2;
		private System.Windows.Forms.ErrorProvider errorProvider3;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Button cmdTimKiem;
		private System.Windows.Forms.Button cmdQuayLai;
	}
}