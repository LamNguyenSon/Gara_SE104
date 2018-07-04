namespace Source
{
	partial class Phutung
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridPhuTung = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdThoat = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaBCT = new System.Windows.Forms.TextBox();
            this.txtTenPhuTung = new System.Windows.Forms.TextBox();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cmdTimKiem = new System.Windows.Forms.Button();
            this.cmdQuayLai = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhuTung)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridPhuTung);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 140);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH PHỤ TÙNG";
            // 
            // dataGridPhuTung
            // 
            this.dataGridPhuTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPhuTung.Location = new System.Drawing.Point(6, 28);
            this.dataGridPhuTung.Name = "dataGridPhuTung";
            this.dataGridPhuTung.Size = new System.Drawing.Size(729, 145);
            this.dataGridPhuTung.TabIndex = 0;
            this.dataGridPhuTung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPhuTung_CellClick);
            this.dataGridPhuTung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPhuTung_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdXoa);
            this.groupBox1.Controls.Add(this.cmdSua);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmdThoat);
            this.groupBox1.Controls.Add(this.cmdThem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaBCT);
            this.groupBox1.Controls.Add(this.txtTenPhuTung);
            this.groupBox1.Controls.Add(this.txtMaPT);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 259);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CẬP NHẬT PHỤ TÙNG";
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
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
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
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(480, 59);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(236, 29);
            this.txtSoLuong.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(376, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Số Lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(480, 24);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(236, 29);
            this.txtDonGia.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mã PT";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Phụ Tùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã BCT";
            // 
            // txtMaBCT
            // 
            this.txtMaBCT.Location = new System.Drawing.Point(110, 59);
            this.txtMaBCT.Name = "txtMaBCT";
            this.txtMaBCT.Size = new System.Drawing.Size(236, 29);
            this.txtMaBCT.TabIndex = 3;
            // 
            // txtTenPhuTung
            // 
            this.txtTenPhuTung.Location = new System.Drawing.Point(110, 94);
            this.txtTenPhuTung.Name = "txtTenPhuTung";
            this.txtTenPhuTung.Size = new System.Drawing.Size(236, 29);
            this.txtTenPhuTung.TabIndex = 2;
            // 
            // txtMaPT
            // 
            this.txtMaPT.Location = new System.Drawing.Point(110, 24);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(236, 29);
            this.txtMaPT.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(12, 316);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(248, 20);
            this.txtTimKiem.TabIndex = 30;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cmdTimKiem
            // 
            this.cmdTimKiem.Location = new System.Drawing.Point(272, 314);
            this.cmdTimKiem.Name = "cmdTimKiem";
            this.cmdTimKiem.Size = new System.Drawing.Size(86, 23);
            this.cmdTimKiem.TabIndex = 31;
            this.cmdTimKiem.Text = "Tìm kiếm";
            this.cmdTimKiem.UseVisualStyleBackColor = true;
            this.cmdTimKiem.Click += new System.EventHandler(this.cmdTimKiem_Click);
            // 
            // cmdQuayLai
            // 
            this.cmdQuayLai.Location = new System.Drawing.Point(374, 313);
            this.cmdQuayLai.Name = "cmdQuayLai";
            this.cmdQuayLai.Size = new System.Drawing.Size(127, 23);
            this.cmdQuayLai.TabIndex = 32;
            this.cmdQuayLai.Text = "Quay lại danh sách";
            this.cmdQuayLai.UseVisualStyleBackColor = true;
            this.cmdQuayLai.Click += new System.EventHandler(this.cmdQuayLai_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Phutung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 523);
            this.Controls.Add(this.cmdQuayLai);
            this.Controls.Add(this.cmdTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Phutung";
            this.Text = "Phutung";
            this.Load += new System.EventHandler(this.Phutung_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhuTung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridPhuTung;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button cmdXoa;
		private System.Windows.Forms.Button cmdSua;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button cmdThoat;
		private System.Windows.Forms.Button cmdThem;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMaBCT;
		private System.Windows.Forms.TextBox txtTenPhuTung;
		private System.Windows.Forms.TextBox txtMaPT;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Button cmdTimKiem;
		private System.Windows.Forms.Button cmdQuayLai;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}