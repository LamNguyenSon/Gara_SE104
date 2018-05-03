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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(109)))), ((int)(((byte)(175)))));
			this.listBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.listBox1.ForeColor = System.Drawing.Color.Green;
			this.listBox1.FormatString = "N2";
			this.listBox1.FormattingEnabled = true;
			this.listBox1.HorizontalScrollbar = true;
			this.listBox1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
			this.listBox1.Location = new System.Drawing.Point(1, 12);
			this.listBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(166, 381);
			this.listBox1.TabIndex = 1;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(112)))), ((int)(((byte)(124)))));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.Cursor = System.Windows.Forms.Cursors.No;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.button1.Location = new System.Drawing.Point(1, 42);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(147, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "HOME";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1, 170);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(147, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "QUẢN LÝ NHÂN VIÊN";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(1, 86);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(147, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "QUẢN LÝ PHỤ TÙNG";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(1, 132);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(147, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "QUẢN LÝ KHÁCH HÀNG";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(53)))), ((int)(((byte)(39)))));
			this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.flowLayoutPanel1.Enabled = false;
			this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(636, 77);
			this.flowLayoutPanel1.TabIndex = 100;
			this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
			// 
			// Home_page
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(154)))), ((int)(((byte)(160)))));
			this.ClientSize = new System.Drawing.Size(660, 411);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Home_page";
			this.ShowIcon = false;
			this.Text = "Main Menu";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		public System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}

