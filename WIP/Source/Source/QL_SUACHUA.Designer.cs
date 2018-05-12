namespace Source
{
    partial class QL_SUACHUA
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bienso = new System.Windows.Forms.TextBox();
            this.loaixe = new System.Windows.Forms.TextBox();
            this.cmnd = new System.Windows.Forms.TextBox();
            this.hoten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tenkhachhang = new System.Windows.Forms.ComboBox();
            this.LOAISC = new System.Windows.Forms.ComboBox();
            this.MOTA = new System.Windows.Forms.TextBox();
            this.CHIPHI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MAPSC = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LOAIPT = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.slptsd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 628);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(337, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông Tin Sửa Chữa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(128, 439);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.bienso);
            this.panel2.Controls.Add(this.loaixe);
            this.panel2.Controls.Add(this.cmnd);
            this.panel2.Controls.Add(this.hoten);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tenkhachhang);
            this.panel2.Location = new System.Drawing.Point(65, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 319);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.slptsd);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.LOAIPT);
            this.panel3.Controls.Add(this.MAPSC);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.CHIPHI);
            this.panel3.Controls.Add(this.MOTA);
            this.panel3.Controls.Add(this.LOAISC);
            this.panel3.Location = new System.Drawing.Point(517, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 319);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // bienso
            // 
            this.bienso.Enabled = false;
            this.bienso.Location = new System.Drawing.Point(208, 207);
            this.bienso.Name = "bienso";
            this.bienso.Size = new System.Drawing.Size(152, 20);
            this.bienso.TabIndex = 21;
            // 
            // loaixe
            // 
            this.loaixe.Enabled = false;
            this.loaixe.Location = new System.Drawing.Point(208, 170);
            this.loaixe.Name = "loaixe";
            this.loaixe.Size = new System.Drawing.Size(152, 20);
            this.loaixe.TabIndex = 20;
            // 
            // cmnd
            // 
            this.cmnd.Enabled = false;
            this.cmnd.Location = new System.Drawing.Point(208, 136);
            this.cmnd.Name = "cmnd";
            this.cmnd.Size = new System.Drawing.Size(152, 20);
            this.cmnd.TabIndex = 19;
            // 
            // hoten
            // 
            this.hoten.Enabled = false;
            this.hoten.Location = new System.Drawing.Point(208, 98);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(152, 20);
            this.hoten.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Biển Số Xe :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Loại Xe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Chứng Minh Nhân Dân :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Họ Tên Khách Hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chọn Khách Hàng :";
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.FormattingEnabled = true;
            this.tenkhachhang.Location = new System.Drawing.Point(208, 49);
            this.tenkhachhang.Name = "tenkhachhang";
            this.tenkhachhang.Size = new System.Drawing.Size(152, 21);
            this.tenkhachhang.TabIndex = 12;
            this.tenkhachhang.SelectedIndexChanged += new System.EventHandler(this.tenkhachhang_SelectedIndexChanged_1);
            // 
            // LOAISC
            // 
            this.LOAISC.FormattingEnabled = true;
            this.LOAISC.Items.AddRange(new object[] {
            "1.Sua Chua",
            "2.Thay Moi"});
            this.LOAISC.Location = new System.Drawing.Point(207, 94);
            this.LOAISC.Name = "LOAISC";
            this.LOAISC.Size = new System.Drawing.Size(121, 21);
            this.LOAISC.TabIndex = 1;
            this.LOAISC.SelectedIndexChanged += new System.EventHandler(this.LOAISC_SelectedIndexChanged);
            // 
            // MOTA
            // 
            this.MOTA.Location = new System.Drawing.Point(207, 214);
            this.MOTA.Name = "MOTA";
            this.MOTA.Size = new System.Drawing.Size(200, 20);
            this.MOTA.TabIndex = 3;
            // 
            // CHIPHI
            // 
            this.CHIPHI.Location = new System.Drawing.Point(207, 252);
            this.CHIPHI.Name = "CHIPHI";
            this.CHIPHI.Size = new System.Drawing.Size(100, 20);
            this.CHIPHI.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã Phiếu Sữa Chữa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Loại Phụ Tùng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mô Tả";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Chi Phí";
            // 
            // MAPSC
            // 
            this.MAPSC.FormattingEnabled = true;
            this.MAPSC.Location = new System.Drawing.Point(207, 46);
            this.MAPSC.Name = "MAPSC";
            this.MAPSC.Size = new System.Drawing.Size(121, 21);
            this.MAPSC.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Loại Sữa Chữa";
            // 
            // LOAIPT
            // 
            this.LOAIPT.FormattingEnabled = true;
            this.LOAIPT.Location = new System.Drawing.Point(207, 128);
            this.LOAIPT.Name = "LOAIPT";
            this.LOAIPT.Size = new System.Drawing.Size(121, 21);
            this.LOAIPT.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(125, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Danh Sách Cần Sửa Chữa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Số Lượng Phụ Tùng Sử Dụng";
            // 
            // slptsd
            // 
            this.slptsd.Location = new System.Drawing.Point(207, 174);
            this.slptsd.Name = "slptsd";
            this.slptsd.Size = new System.Drawing.Size(100, 20);
            this.slptsd.TabIndex = 13;
            // 
            // QL_SUACHUA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 652);
            this.Controls.Add(this.panel1);
            this.Name = "QL_SUACHUA";
            this.Text = "QL_SUACHUA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox bienso;
        private System.Windows.Forms.TextBox loaixe;
        private System.Windows.Forms.TextBox cmnd;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tenkhachhang;
        private System.Windows.Forms.ComboBox LOAIPT;
        private System.Windows.Forms.ComboBox MAPSC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CHIPHI;
        private System.Windows.Forms.TextBox MOTA;
        private System.Windows.Forms.ComboBox LOAISC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox slptsd;
        private System.Windows.Forms.Label label13;
    }
}