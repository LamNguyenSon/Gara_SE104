namespace Source
{
	partial class LẬP_PHIẾU_THU_TIỀN
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
			this.txtMaTT = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnLuu = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTienThu = new System.Windows.Forms.TextBox();
			this.btnInPhieu = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.dtNgayThu = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// txtMaTT
			// 
			this.txtMaTT.Location = new System.Drawing.Point(113, 19);
			this.txtMaTT.Name = "txtMaTT";
			this.txtMaTT.Size = new System.Drawing.Size(130, 20);
			this.txtMaTT.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(175, 108);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(91, 27);
			this.btnLuu.TabIndex = 2;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mã TT";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tiền Thu";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(311, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ngày Thu";
			// 
			// txtTienThu
			// 
			this.txtTienThu.Location = new System.Drawing.Point(113, 53);
			this.txtTienThu.Name = "txtTienThu";
			this.txtTienThu.Size = new System.Drawing.Size(130, 20);
			this.txtTienThu.TabIndex = 6;
			// 
			// btnInPhieu
			// 
			this.btnInPhieu.Location = new System.Drawing.Point(274, 108);
			this.btnInPhieu.Name = "btnInPhieu";
			this.btnInPhieu.Size = new System.Drawing.Size(91, 27);
			this.btnInPhieu.TabIndex = 8;
			this.btnInPhieu.Text = "In phiếu";
			this.btnInPhieu.UseVisualStyleBackColor = true;
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(380, 108);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(91, 27);
			this.btnThoat.TabIndex = 9;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			// 
			// dtNgayThu
			// 
			this.dtNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtNgayThu.Location = new System.Drawing.Point(371, 19);
			this.dtNgayThu.Name = "dtNgayThu";
			this.dtNgayThu.Size = new System.Drawing.Size(139, 20);
			this.dtNgayThu.TabIndex = 10;
			// 
			// LẬP_PHIẾU_THU_TIỀN
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(611, 180);
			this.Controls.Add(this.dtNgayThu);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnInPhieu);
			this.Controls.Add(this.txtTienThu);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.txtMaTT);
			this.Name = "LẬP_PHIẾU_THU_TIỀN";
			this.Text = "LẬP PHIẾU THU TIỀN";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMaTT;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTienThu;
		private System.Windows.Forms.Button btnInPhieu;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.DateTimePicker dtNgayThu;
	}
}