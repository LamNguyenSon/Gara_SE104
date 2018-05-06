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
			this.dataGridNhanVien = new System.Windows.Forms.DataGridView();
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
			this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridNhanVien)).BeginInit();
			this.SuspendLayout();
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(64, 142);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(72, 26);
			this.btnThem.TabIndex = 13;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(220, 142);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(72, 26);
			this.btnXoa.TabIndex = 14;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Location = new System.Drawing.Point(142, 142);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(72, 26);
			this.btnCapNhat.TabIndex = 15;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Location = new System.Drawing.Point(347, 186);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(72, 26);
			this.btnTimKiem.TabIndex = 16;
			this.btnTimKiem.Text = "Tìm ";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 193);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Tìm kiếm nhân viên";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(652, 142);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(72, 26);
			this.btnThoat.TabIndex = 18;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			// 
			// dataGridNhanVien
			// 
			this.dataGridNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colDiaChi,
            this.colCMND,
            this.colGioiTinh});
			this.dataGridNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridNhanVien.Location = new System.Drawing.Point(0, 219);
			this.dataGridNhanVien.Name = "dataGridNhanVien";
			this.dataGridNhanVien.Size = new System.Drawing.Size(804, 195);
			this.dataGridNhanVien.TabIndex = 19;
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(574, 142);
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
			this.label4.Location = new System.Drawing.Point(456, 43);
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
			this.label3.Location = new System.Drawing.Point(13, 69);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Họ Tên";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// txtCMND
			// 
			this.txtCMND.Location = new System.Drawing.Point(517, 40);
			this.txtCMND.Name = "txtCMND";
			this.txtCMND.Size = new System.Drawing.Size(149, 20);
			this.txtCMND.TabIndex = 7;
			this.txtCMND.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(65, 66);
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
			this.label5.Location = new System.Drawing.Point(13, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Địa Chỉ";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(65, 92);
			this.txtDiaChi.Multiline = true;
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(355, 35);
			this.txtDiaChi.TabIndex = 8;
			this.txtDiaChi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(124, 190);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(217, 20);
			this.txtTimKiem.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(456, 69);
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
            "Nữ"});
			this.cbGioiTinh.Location = new System.Drawing.Point(517, 66);
			this.cbGioiTinh.Name = "cbGioiTinh";
			this.cbGioiTinh.Size = new System.Drawing.Size(72, 21);
			this.cbGioiTinh.TabIndex = 21;
			this.cbGioiTinh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// colMaNV
			// 
			this.colMaNV.DataPropertyName = "MaNV";
			this.colMaNV.HeaderText = "Mã NV";
			this.colMaNV.Name = "colMaNV";
			this.colMaNV.Width = 115;
			// 
			// colHoTen
			// 
			this.colHoTen.DataPropertyName = "HoTen";
			this.colHoTen.HeaderText = "Họ Tên";
			this.colHoTen.Name = "colHoTen";
			this.colHoTen.Width = 200;
			// 
			// colDiaChi
			// 
			this.colDiaChi.DataPropertyName = "DiaChi";
			this.colDiaChi.HeaderText = "Địa Chỉ";
			this.colDiaChi.Name = "colDiaChi";
			this.colDiaChi.Width = 200;
			// 
			// colCMND
			// 
			this.colCMND.DataPropertyName = "GioiTinh";
			this.colCMND.HeaderText = "CMND";
			this.colCMND.Name = "colCMND";
			this.colCMND.Width = 150;
			// 
			// colGioiTinh
			// 
			this.colGioiTinh.DataPropertyName = "GioiTinh";
			this.colGioiTinh.HeaderText = "Giới Tính";
			this.colGioiTinh.Name = "colGioiTinh";
			// 
			// QUẢN_LÝ_NHÂN_VIÊN
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 414);
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
		private System.Windows.Forms.DataGridView dataGridNhanVien;
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
		private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
		private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
	}
}