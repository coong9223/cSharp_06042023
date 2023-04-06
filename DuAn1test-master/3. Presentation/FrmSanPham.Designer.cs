namespace _3._Presentation
{
    partial class FrmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbt_timkSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgv_frmSP = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_ghichu = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rd_ngungkd = new System.Windows.Forms.RadioButton();
            this.rd_kd = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_loaihang = new System.Windows.Forms.ComboBox();
            this.cbb_nhasanxuat = new System.Windows.Forms.ComboBox();
            this.tb_tensp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbt_stock = new System.Windows.Forms.TextBox();
            this.tbt_giaban = new System.Windows.Forms.TextBox();
            this.tbt_gianhap = new System.Windows.Forms.TextBox();
            this.tbt_maSP = new System.Windows.Forms.TextBox();
            this.pcb_anhSP = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_frmSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_anhSP)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(-5, -8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 927);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbt_timkSP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtgv_frmSP);
            this.groupBox2.Location = new System.Drawing.Point(18, 395);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1189, 415);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // tbt_timkSP
            // 
            this.tbt_timkSP.Location = new System.Drawing.Point(168, 55);
            this.tbt_timkSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_timkSP.Name = "tbt_timkSP";
            this.tbt_timkSP.Size = new System.Drawing.Size(198, 27);
            this.tbt_timkSP.TabIndex = 3;
            this.tbt_timkSP.TextChanged += new System.EventHandler(this.tbt_timkSP_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tìm kiếm sản phẩm";
            // 
            // dtgv_frmSP
            // 
            this.dtgv_frmSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_frmSP.Location = new System.Drawing.Point(7, 120);
            this.dtgv_frmSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgv_frmSP.Name = "dtgv_frmSP";
            this.dtgv_frmSP.RowHeadersWidth = 51;
            this.dtgv_frmSP.RowTemplate.Height = 25;
            this.dtgv_frmSP.Size = new System.Drawing.Size(1176, 272);
            this.dtgv_frmSP.TabIndex = 0;
            this.dtgv_frmSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_frmSP_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tb_ghichu);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbb_loaihang);
            this.groupBox1.Controls.Add(this.cbb_nhasanxuat);
            this.groupBox1.Controls.Add(this.tb_tensp);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbt_stock);
            this.groupBox1.Controls.Add(this.tbt_giaban);
            this.groupBox1.Controls.Add(this.tbt_gianhap);
            this.groupBox1.Controls.Add(this.tbt_maSP);
            this.groupBox1.Controls.Add(this.pcb_anhSP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(979, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // tb_ghichu
            // 
            this.tb_ghichu.Location = new System.Drawing.Point(798, 271);
            this.tb_ghichu.Name = "tb_ghichu";
            this.tb_ghichu.Size = new System.Drawing.Size(165, 27);
            this.tb_ghichu.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rd_ngungkd);
            this.panel2.Controls.Add(this.rd_kd);
            this.panel2.Location = new System.Drawing.Point(425, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 53);
            this.panel2.TabIndex = 25;
            // 
            // rd_ngungkd
            // 
            this.rd_ngungkd.AutoSize = true;
            this.rd_ngungkd.Location = new System.Drawing.Point(133, 19);
            this.rd_ngungkd.Name = "rd_ngungkd";
            this.rd_ngungkd.Size = new System.Drawing.Size(153, 24);
            this.rd_ngungkd.TabIndex = 27;
            this.rd_ngungkd.TabStop = true;
            this.rd_ngungkd.Text = "Ngưng kinh doanh";
            this.rd_ngungkd.UseVisualStyleBackColor = true;
            // 
            // rd_kd
            // 
            this.rd_kd.AutoSize = true;
            this.rd_kd.Location = new System.Drawing.Point(17, 19);
            this.rd_kd.Name = "rd_kd";
            this.rd_kd.Size = new System.Drawing.Size(105, 24);
            this.rd_kd.TabIndex = 26;
            this.rd_kd.TabStop = true;
            this.rd_kd.Text = "Kinh doanh";
            this.rd_kd.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Loại hàng";
            // 
            // cbb_loaihang
            // 
            this.cbb_loaihang.FormattingEnabled = true;
            this.cbb_loaihang.Location = new System.Drawing.Point(442, 201);
            this.cbb_loaihang.Name = "cbb_loaihang";
            this.cbb_loaihang.Size = new System.Drawing.Size(162, 28);
            this.cbb_loaihang.TabIndex = 22;
            // 
            // cbb_nhasanxuat
            // 
            this.cbb_nhasanxuat.FormattingEnabled = true;
            this.cbb_nhasanxuat.Location = new System.Drawing.Point(442, 128);
            this.cbb_nhasanxuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_nhasanxuat.Name = "cbb_nhasanxuat";
            this.cbb_nhasanxuat.Size = new System.Drawing.Size(162, 28);
            this.cbb_nhasanxuat.TabIndex = 21;
            // 
            // tb_tensp
            // 
            this.tb_tensp.Location = new System.Drawing.Point(141, 128);
            this.tb_tensp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_tensp.Name = "tb_tensp";
            this.tb_tensp.Size = new System.Drawing.Size(162, 27);
            this.tb_tensp.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tên sản phẩm";
            // 
            // tbt_stock
            // 
            this.tbt_stock.Location = new System.Drawing.Point(442, 48);
            this.tbt_stock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_stock.Name = "tbt_stock";
            this.tbt_stock.Size = new System.Drawing.Size(162, 27);
            this.tbt_stock.TabIndex = 14;
            this.tbt_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbt_stock_KeyPress);
            // 
            // tbt_giaban
            // 
            this.tbt_giaban.Location = new System.Drawing.Point(141, 271);
            this.tbt_giaban.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_giaban.Name = "tbt_giaban";
            this.tbt_giaban.Size = new System.Drawing.Size(162, 27);
            this.tbt_giaban.TabIndex = 13;
            this.tbt_giaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbt_giaban_KeyPress);
            // 
            // tbt_gianhap
            // 
            this.tbt_gianhap.Location = new System.Drawing.Point(141, 201);
            this.tbt_gianhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_gianhap.Name = "tbt_gianhap";
            this.tbt_gianhap.Size = new System.Drawing.Size(162, 27);
            this.tbt_gianhap.TabIndex = 12;
            this.tbt_gianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbt_gianhap_KeyPress);
            // 
            // tbt_maSP
            // 
            this.tbt_maSP.Location = new System.Drawing.Point(141, 52);
            this.tbt_maSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_maSP.Name = "tbt_maSP";
            this.tbt_maSP.Size = new System.Drawing.Size(162, 27);
            this.tbt_maSP.TabIndex = 10;
            // 
            // pcb_anhSP
            // 
            this.pcb_anhSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb_anhSP.Image = ((System.Drawing.Image)(resources.GetObject("pcb_anhSP.Image")));
            this.pcb_anhSP.Location = new System.Drawing.Point(691, 40);
            this.pcb_anhSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcb_anhSP.Name = "pcb_anhSP";
            this.pcb_anhSP.Size = new System.Drawing.Size(196, 208);
            this.pcb_anhSP.TabIndex = 9;
            this.pcb_anhSP.TabStop = false;
            this.pcb_anhSP.Click += new System.EventHandler(this.pcb_anhSP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(730, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ghi chú";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trạng thái";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhà sản xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(1005, 21);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(202, 365);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(37, 81);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(131, 44);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Cập Nhập";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(37, 29);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(131, 44);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // FrmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1216, 855);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSanPham";
            this.Text = "Sản phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSanPham_FormClosed);
            this.Load += new System.EventHandler(this.FrmSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_frmSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_anhSP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pcb_anhSP;
        private TextBox tbt_stock;
        private TextBox tbt_giaban;
        private TextBox tbt_gianhap;
        private TextBox tbt_maSP;
        private GroupBox groupBox3;
        private Button btn_sua;
        private Button btn_them;
        private Label label5;
        private DataGridView dtgv_frmSP;
        private TextBox tbt_timkSP;
        private TextBox tb_tensp;
        private Label label10;
        private ComboBox cbb_nhasanxuat;
        private Label label8;
        private ComboBox cbb_loaihang;
        private TextBox tb_ghichu;
        private Panel panel2;
        private RadioButton rd_ngungkd;
        private RadioButton rd_kd;
    }
}