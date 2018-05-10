namespace Source
{
    partial class Home_page
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
			this.button1 = new System.Windows.Forms.Button();
			this.khachhang = new System.Windows.Forms.Button();
			this.Nhanvien = new System.Windows.Forms.Button();
			this.Phutung = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AllowDrop = true;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.khachhang);
			this.panel1.Controls.Add(this.Nhanvien);
			this.panel1.Controls.Add(this.Phutung);
			this.panel1.Location = new System.Drawing.Point(53, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(162, 343);
			this.panel1.TabIndex = 101;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.Location = new System.Drawing.Point(0, 54);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(162, 41);
			this.button1.TabIndex = 6;
			this.button1.Text = "HOME";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseMnemonic = false;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.UseWaitCursor = true;
			// 
			// khachhang
			// 
			this.khachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
			this.khachhang.Location = new System.Drawing.Point(0, 128);
			this.khachhang.Name = "khachhang";
			this.khachhang.Size = new System.Drawing.Size(162, 41);
			this.khachhang.TabIndex = 5;
			this.khachhang.Text = "QUẢN LÝ KHÁCH HÀNG";
			this.khachhang.UseVisualStyleBackColor = false;
			this.khachhang.Click += new System.EventHandler(this.khachhang_Click);
			// 
			// Nhanvien
			// 
			this.Nhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
			this.Nhanvien.Location = new System.Drawing.Point(0, 163);
			this.Nhanvien.Name = "Nhanvien";
			this.Nhanvien.Size = new System.Drawing.Size(162, 41);
			this.Nhanvien.TabIndex = 3;
			this.Nhanvien.Text = "QUẢN LÝ NHÂN VIÊN";
			this.Nhanvien.UseVisualStyleBackColor = false;
			this.Nhanvien.Click += new System.EventHandler(this.nhanvien_Click);
			// 
			// Phutung
			// 
			this.Phutung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
			this.Phutung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Phutung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Phutung.Location = new System.Drawing.Point(0, 89);
			this.Phutung.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
			this.Phutung.Name = "Phutung";
			this.Phutung.Size = new System.Drawing.Size(162, 41);
			this.Phutung.TabIndex = 4;
			this.Phutung.Text = "QUẢN LÝ PHỤ TÙNG";
			this.Phutung.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Phutung.UseMnemonic = false;
			this.Phutung.UseVisualStyleBackColor = false;
			this.Phutung.UseWaitCursor = true;
			this.Phutung.ClientSizeChanged += new System.EventHandler(this.button2_Click);
			this.Phutung.ContextMenuStripChanged += new System.EventHandler(this.button1_Click);
			this.Phutung.Click += new System.EventHandler(this.button3_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
			this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.flowLayoutPanel1.Enabled = false;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 26);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(664, 66);
			this.flowLayoutPanel1.TabIndex = 100;
			this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
			// 
			// Home_page
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(154)))), ((int)(((byte)(160)))));
			this.ClientSize = new System.Drawing.Size(660, 411);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
=======
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(668, 435);
			this.Controls.Add(this.panel1);
>>>>>>> origin/master
			this.Controls.Add(this.flowLayoutPanel1);
			this.MaximizeBox = false;
			this.Name = "Home_page";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Menu";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Shown += new System.EventHandler(this.button1_Click);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.Button Nhanvien;
		private System.Windows.Forms.Button Phutung;
		private System.Windows.Forms.Button khachhang;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
	}
}

