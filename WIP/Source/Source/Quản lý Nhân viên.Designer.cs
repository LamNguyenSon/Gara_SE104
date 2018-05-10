namespace Source
{
	partial class QUẢN_LÝ_NHÂN_VIÊN
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
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.btnThoat = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.btnLuu = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCMND = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbGioiTinh = new System.Windows.Forms.ComboBox();
			this.dataGridNhanVien = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.txtMaTK = new System.Windows.Forms.TextBox();
			this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridNhanVien)).BeginInit();
			this.SuspendLayout();
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(64, 164);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(72, 26);
			this.btnThem.TabIndex = 13;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(220, 164);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(72, 26);
			this.btnXoa.TabIndex = 14;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Location = new System.Drawing.Point(142, 164);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(72, 26);
			this.btnCapNhat.TabIndex = 15;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(347, 201);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(72, 26);
			this.btnTimKiem.TabIndex = 16;
			this.btnTimKiem.Text = "Tìm ";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 208);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Tìm kiếm nhân viên";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(652, 164);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(72, 26);
			this.btnThoat.TabIndex = 18;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(574, 164);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(72, 26);
			this.btnLuu.TabIndex = 20;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(396, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "CMND";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(302, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thông tin Nhân viên";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Họ Tên";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// txtCMND
			// 
			this.txtCMND.Location = new System.Drawing.Point(455, 92);
			this.txtCMND.Name = "txtCMND";
			this.txtCMND.Size = new System.Drawing.Size(149, 20);
			this.txtCMND.TabIndex = 7;
			this.txtCMND.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(65, 92);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(237, 20);
			this.txtHoTen.TabIndex = 4;
			// 
			// txtMaNV
			// 
			this.txtMaNV.Location = new System.Drawing.Point(65, 40);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(118, 20);
			this.txtMaNV.TabIndex = 3;
			this.txtMaNV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mã NV";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(396, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Địa Chỉ";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(455, 118);
			this.txtDiaChi.Multiline = true;
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(337, 35);
			this.txtDiaChi.TabIndex = 8;
			this.txtDiaChi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(117, 205);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(217, 20);
			this.txtTimKiem.TabIndex = 20;
			this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(14, 121);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Giới Tính";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// cbGioiTinh
			// 
			this.cbGioiTinh.FormattingEnabled = true;
			this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
			this.cbGioiTinh.Location = new System.Drawing.Point(65, 118);
			this.cbGioiTinh.Name = "cbGioiTinh";
			this.cbGioiTinh.Size = new System.Drawing.Size(72, 21);
			this.cbGioiTinh.TabIndex = 21;
			this.cbGioiTinh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// dataGridNhanVien
			// 
			this.dataGridNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridNhanVien.Location = new System.Drawing.Point(0, 233);
			this.dataGridNhanVien.Name = "dataGridNhanVien";
			this.dataGridNhanVien.Size = new System.Drawing.Size(804, 181);
			this.dataGridNhanVien.TabIndex = 19;
			this.dataGridNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNhanVien_CellClick);
			this.dataGridNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNhanVien_CellContentClick);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(14, 69);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 13);
			this.label8.TabIndex = 22;
			this.label8.Text = "Mã TK";
			// 
			// txtMaTK
			// 
			this.txtMaTK.Location = new System.Drawing.Point(65, 66);
			this.txtMaTK.Name = "txtMaTK";
			this.txtMaTK.Size = new System.Drawing.Size(118, 20);
			this.txtMaTK.TabIndex = 23;
			// 
			// dtNgaySinh
			// 
			this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtNgaySinh.Location = new System.Drawing.Point(455, 40);
			this.dtNgaySinh.Name = "dtNgaySinh";
			this.dtNgaySinh.Size = new System.Drawing.Size(149, 20);
			this.dtNgaySinh.TabIndex = 24;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(396, 43);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 13);
			this.label9.TabIndex = 25;
			this.label9.Text = "Ngày Sinh";
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(455, 66);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(149, 20);
			this.txtSDT.TabIndex = 26;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(396, 69);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 13);
			this.label10.TabIndex = 27;
			this.label10.Text = "Số ĐT";
			// 
			// QUẢN_LÝ_NHÂN_VIÊN
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 414);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtSDT);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dtNgaySinh);
			this.Controls.Add(this.txtMaTK);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMaNV);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbGioiTinh);
			this.Controls.Add(this.txtTimKiem);
			this.Controls.Add(this.txtCMND);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtDiaChi);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.dataGridNhanVien);
			this.Controls.Add(this.btnTimKiem);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnCapNhat);
			this.Name = "QUẢN_LÝ_NHÂN_VIÊN";
			this.Text = "QUẢN LÝ NHÂN VIÊN";
			this.Load += new System.EventHandler(this.QUẢN_LÝ_NHÂN_VIÊN_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridNhanVien)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnThoat;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCMND;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbGioiTinh;
		private System.Windows.Forms.DataGridView dataGridNhanVien;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtMaTK;
		private System.Windows.Forms.DateTimePicker dtNgaySinh;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.Label label10;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
	}
}