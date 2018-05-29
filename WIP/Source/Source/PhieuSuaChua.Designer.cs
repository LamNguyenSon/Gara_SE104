namespace Source
{
	partial class PhieuSuaChua
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.NGAYSUACHUA = new System.Windows.Forms.DateTimePicker();
            this.MANV = new System.Windows.Forms.ComboBox();
            this.MAPSC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CMND = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.INSERT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.makh = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.makh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.NGAYSUACHUA);
            this.panel1.Controls.Add(this.MANV);
            this.panel1.Controls.Add(this.MAPSC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CMND);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.INSERT);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 236);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Khách Hàng";
            // 
            // NGAYSUACHUA
            // 
            this.NGAYSUACHUA.Location = new System.Drawing.Point(232, 128);
            this.NGAYSUACHUA.Name = "NGAYSUACHUA";
            this.NGAYSUACHUA.Size = new System.Drawing.Size(200, 20);
            this.NGAYSUACHUA.TabIndex = 11;
            // 
            // MANV
            // 
            this.MANV.FormattingEnabled = true;
            this.MANV.Location = new System.Drawing.Point(232, 90);
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(121, 21);
            this.MANV.TabIndex = 10;
            // 
            // MAPSC
            // 
            this.MAPSC.Location = new System.Drawing.Point(232, 21);
            this.MAPSC.Name = "MAPSC";
            this.MAPSC.Size = new System.Drawing.Size(200, 20);
            this.MAPSC.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Sữa Chữa";
            // 
            // CMND
            // 
            this.CMND.AutoSize = true;
            this.CMND.Location = new System.Drawing.Point(51, 99);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(75, 13);
            this.CMND.TabIndex = 2;
            this.CMND.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Mã Phiếu Sữa Chữa Mới :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // INSERT
            // 
            this.INSERT.Location = new System.Drawing.Point(343, 179);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(89, 32);
            this.INSERT.TabIndex = 0;
            this.INSERT.Text = "Insert";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thêm Phiếu Sữa Chữa";
            // 
            // makh
            // 
            this.makh.Enabled = false;
            this.makh.Location = new System.Drawing.Point(232, 59);
            this.makh.Name = "makh";
            this.makh.Size = new System.Drawing.Size(121, 20);
            this.makh.TabIndex = 14;
            // 
            // PhieuSuaChua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 335);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "PhieuSuaChua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuSuaChua";
            this.Load += new System.EventHandler(this.PhieuSuaChua_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label CMND;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button INSERT;
		private System.Windows.Forms.TextBox MAPSC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MANV;
        private System.Windows.Forms.DateTimePicker NGAYSUACHUA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox makh;
    }
}