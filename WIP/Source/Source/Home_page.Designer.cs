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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(39)))));
			this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.flowLayoutPanel1.Enabled = false;
			this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 26);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(586, 57);
			this.flowLayoutPanel1.TabIndex = 100;
			this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
			// 
			// panel1
			// 
			this.panel1.AllowDrop = true;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
			this.panel1.BackgroundImage = global::Source.Properties.Resources.depositphotos_50098993_stock_photo_blue_wood_texture_of_rough;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Location = new System.Drawing.Point(12, 47);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(165, 398);
			this.panel1.TabIndex = 101;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(124)))));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.Cursor = System.Windows.Forms.Cursors.No;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.button1.Location = new System.Drawing.Point(3, 42);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "HOME";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(3, 139);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(131, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "QUẢN LÝ KHÁCH HÀNG";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(3, 159);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(131, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "QUẢN LÝ NHÂN VIÊN";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button3.Image = global::Source.Properties.Resources.configuration1;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.Location = new System.Drawing.Point(3, 81);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(159, 40);
			this.button3.TabIndex = 4;
			this.button3.Text = "QUẢN LÝ PHỤ TÙNG";
			this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseMnemonic = false;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.UseWaitCursor = true;
			this.button3.ClientSizeChanged += new System.EventHandler(this.button2_Click);
			this.button3.ContextMenuStripChanged += new System.EventHandler(this.button1_Click);
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Home_page
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(154)))), ((int)(((byte)(160)))));
			this.BackgroundImage = global::Source.Properties.Resources._2014_aston_martin_rapide_s_test_review_car_and_driver_photo_507236_s_429x262;
			this.ClientSize = new System.Drawing.Size(358, 244);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.MaximizeBox = false;
			this.Name = "Home_page";
			this.ShowIcon = false;
			this.Text = "Main Menu";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Shown += new System.EventHandler(this.button1_Click);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
	}
}

