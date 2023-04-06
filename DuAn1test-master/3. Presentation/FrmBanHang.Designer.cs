namespace _3._Presentation
{
    partial class FrmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_hdcho = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbt_timkSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_danhsachSP = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_giamgia = new System.Windows.Forms.Label();
            this.tbt_mahd = new System.Windows.Forms.TextBox();
            this.tbt_tienkhachdua = new System.Windows.Forms.TextBox();
            this.tbt_giamgia = new System.Windows.Forms.TextBox();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.rtb_ghichu = new System.Windows.Forms.RichTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_tienthua = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbb_listcamera = new System.Windows.Forms.ComboBox();
            this.btn_capNhapHĐ = new System.Windows.Forms.Button();
            this.lb_point = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_tenkh = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_xoaGioHang = new System.Windows.Forms.Button();
            this.btn_XoaSP = new System.Windows.Forms.Button();
            this.lb_totalcart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_giohang = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hdcho)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_giohang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-6, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1446, 992);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_hdcho);
            this.groupBox4.Location = new System.Drawing.Point(938, 7);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(285, 400);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đơn Hàng Chờ";
            // 
            // dgv_hdcho
            // 
            this.dgv_hdcho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hdcho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column11});
            this.dgv_hdcho.Location = new System.Drawing.Point(6, 47);
            this.dgv_hdcho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_hdcho.Name = "dgv_hdcho";
            this.dgv_hdcho.RowHeadersWidth = 51;
            this.dgv_hdcho.RowTemplate.Height = 25;
            this.dgv_hdcho.Size = new System.Drawing.Size(272, 337);
            this.dgv_hdcho.TabIndex = 0;
            this.dgv_hdcho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hdcho_CellClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mã hóa đơn";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 55;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Tên khách hàng";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 160;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbt_timkSP);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtg_danhsachSP);
            this.groupBox3.Location = new System.Drawing.Point(19, 415);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(792, 427);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sản phẩm";
            // 
            // tbt_timkSP
            // 
            this.tbt_timkSP.Location = new System.Drawing.Point(18, 85);
            this.tbt_timkSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_timkSP.Multiline = true;
            this.tbt_timkSP.Name = "tbt_timkSP";
            this.tbt_timkSP.Size = new System.Drawing.Size(194, 40);
            this.tbt_timkSP.TabIndex = 3;
            this.tbt_timkSP.TextChanged += new System.EventHandler(this.tbt_timkSP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm sản phẩm";
            // 
            // dtg_danhsachSP
            // 
            this.dtg_danhsachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_danhsachSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5});
            this.dtg_danhsachSP.Location = new System.Drawing.Point(7, 159);
            this.dtg_danhsachSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg_danhsachSP.Name = "dtg_danhsachSP";
            this.dtg_danhsachSP.RowHeadersWidth = 51;
            this.dtg_danhsachSP.RowTemplate.Height = 25;
            this.dtg_danhsachSP.Size = new System.Drawing.Size(775, 283);
            this.dtg_danhsachSP.TabIndex = 1;
            this.dtg_danhsachSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_danhsachSP_CellClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã sản phẩm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên nhà sản xuất";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số lượng tồn";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_giamgia);
            this.groupBox2.Controls.Add(this.tbt_mahd);
            this.groupBox2.Controls.Add(this.tbt_tienkhachdua);
            this.groupBox2.Controls.Add(this.tbt_giamgia);
            this.groupBox2.Controls.Add(this.btn_thanhtoan);
            this.groupBox2.Controls.Add(this.rtb_ghichu);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lb_tienthua);
            this.groupBox2.Controls.Add(this.lb_tongtien);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(818, 415);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(405, 427);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh toán";
            // 
            // lb_giamgia
            // 
            this.lb_giamgia.AutoSize = true;
            this.lb_giamgia.Location = new System.Drawing.Point(279, 90);
            this.lb_giamgia.Name = "lb_giamgia";
            this.lb_giamgia.Size = new System.Drawing.Size(80, 20);
            this.lb_giamgia.TabIndex = 43;
            this.lb_giamgia.Text = "(Tối đa : 0)";
            // 
            // tbt_mahd
            // 
            this.tbt_mahd.Location = new System.Drawing.Point(163, 32);
            this.tbt_mahd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_mahd.Name = "tbt_mahd";
            this.tbt_mahd.Size = new System.Drawing.Size(114, 27);
            this.tbt_mahd.TabIndex = 42;
            this.tbt_mahd.TextChanged += new System.EventHandler(this.tbt_mahd_TextChanged);
            // 
            // tbt_tienkhachdua
            // 
            this.tbt_tienkhachdua.Location = new System.Drawing.Point(165, 137);
            this.tbt_tienkhachdua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_tienkhachdua.Name = "tbt_tienkhachdua";
            this.tbt_tienkhachdua.Size = new System.Drawing.Size(114, 27);
            this.tbt_tienkhachdua.TabIndex = 41;
            this.tbt_tienkhachdua.TextChanged += new System.EventHandler(this.tbt_tienkhachdua_TextChanged);
            // 
            // tbt_giamgia
            // 
            this.tbt_giamgia.Location = new System.Drawing.Point(163, 85);
            this.tbt_giamgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_giamgia.Name = "tbt_giamgia";
            this.tbt_giamgia.Size = new System.Drawing.Size(114, 27);
            this.tbt_giamgia.TabIndex = 40;
            this.tbt_giamgia.TextChanged += new System.EventHandler(this.tbt_giamgia_TextChanged);
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_thanhtoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_thanhtoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_thanhtoan.Image")));
            this.btn_thanhtoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thanhtoan.Location = new System.Drawing.Point(91, 344);
            this.btn_thanhtoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(242, 63);
            this.btn_thanhtoan.TabIndex = 39;
            this.btn_thanhtoan.Text = "THANH TOÁN";
            this.btn_thanhtoan.UseVisualStyleBackColor = false;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // rtb_ghichu
            // 
            this.rtb_ghichu.Location = new System.Drawing.Point(165, 291);
            this.rtb_ghichu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtb_ghichu.Name = "rtb_ghichu";
            this.rtb_ghichu.Size = new System.Drawing.Size(187, 27);
            this.rtb_ghichu.TabIndex = 38;
            this.rtb_ghichu.Text = "";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(38, 299);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 20);
            this.label21.TabIndex = 37;
            this.label21.Text = "Ghi chú";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(311, 193);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 20);
            this.label20.TabIndex = 36;
            this.label20.Text = "VNĐ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(311, 141);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 20);
            this.label19.TabIndex = 35;
            this.label19.Text = "VNĐ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(311, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "VNĐ";
            // 
            // lb_tienthua
            // 
            this.lb_tienthua.AutoSize = true;
            this.lb_tienthua.Location = new System.Drawing.Point(163, 193);
            this.lb_tienthua.Name = "lb_tienthua";
            this.lb_tienthua.Size = new System.Drawing.Size(17, 20);
            this.lb_tienthua.TabIndex = 33;
            this.lb_tienthua.Text = "0";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Location = new System.Drawing.Point(163, 243);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(17, 20);
            this.lb_tongtien.TabIndex = 32;
            this.lb_tongtien.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Tiền thừa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tiền khách đưa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Giảm giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã hóa đơn ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cbb_listcamera);
            this.groupBox1.Controls.Add(this.btn_capNhapHĐ);
            this.groupBox1.Controls.Add(this.lb_point);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lb_tenkh);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_sdt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_xoaGioHang);
            this.groupBox1.Controls.Add(this.btn_XoaSP);
            this.groupBox1.Controls.Add(this.lb_totalcart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtg_giohang);
            this.groupBox1.Location = new System.Drawing.Point(19, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(912, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ hàng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cbb_listcamera
            // 
            this.cbb_listcamera.FormattingEnabled = true;
            this.cbb_listcamera.Location = new System.Drawing.Point(139, 357);
            this.cbb_listcamera.Name = "cbb_listcamera";
            this.cbb_listcamera.Size = new System.Drawing.Size(151, 28);
            this.cbb_listcamera.TabIndex = 1;
            // 
            // btn_capNhapHĐ
            // 
            this.btn_capNhapHĐ.Image = ((System.Drawing.Image)(resources.GetObject("btn_capNhapHĐ.Image")));
            this.btn_capNhapHĐ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_capNhapHĐ.Location = new System.Drawing.Point(442, 291);
            this.btn_capNhapHĐ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_capNhapHĐ.Name = "btn_capNhapHĐ";
            this.btn_capNhapHĐ.Size = new System.Drawing.Size(126, 44);
            this.btn_capNhapHĐ.TabIndex = 24;
            this.btn_capNhapHĐ.Text = "Cập Nhập HĐ";
            this.btn_capNhapHĐ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_capNhapHĐ.UseVisualStyleBackColor = true;
            this.btn_capNhapHĐ.Click += new System.EventHandler(this.btn_capNhapHĐ_Click);
            // 
            // lb_point
            // 
            this.lb_point.AutoSize = true;
            this.lb_point.Location = new System.Drawing.Point(723, 121);
            this.lb_point.Name = "lb_point";
            this.lb_point.Size = new System.Drawing.Size(18, 20);
            this.lb_point.TabIndex = 23;
            this.lb_point.Text = "...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(606, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Điểm tích lũy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(606, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 204);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lb_tenkh
            // 
            this.lb_tenkh.AutoSize = true;
            this.lb_tenkh.Location = new System.Drawing.Point(723, 79);
            this.lb_tenkh.Name = "lb_tenkh";
            this.lb_tenkh.Size = new System.Drawing.Size(18, 20);
            this.lb_tenkh.TabIndex = 20;
            this.lb_tenkh.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(606, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tên khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(606, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sđt khách hàng";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(722, 35);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(125, 27);
            this.tb_sdt.TabIndex = 17;
            this.tb_sdt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(295, 291);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Tạo hóa đơn";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_xoaGioHang
            // 
            this.btn_xoaGioHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoaGioHang.Image")));
            this.btn_xoaGioHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoaGioHang.Location = new System.Drawing.Point(149, 291);
            this.btn_xoaGioHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoaGioHang.Name = "btn_xoaGioHang";
            this.btn_xoaGioHang.Size = new System.Drawing.Size(126, 44);
            this.btn_xoaGioHang.TabIndex = 15;
            this.btn_xoaGioHang.Text = "Xóa giỏ hàng";
            this.btn_xoaGioHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoaGioHang.UseVisualStyleBackColor = true;
            this.btn_xoaGioHang.Click += new System.EventHandler(this.btn_xoaGioHang_Click_1);
            // 
            // btn_XoaSP
            // 
            this.btn_XoaSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaSP.Image")));
            this.btn_XoaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaSP.Location = new System.Drawing.Point(6, 291);
            this.btn_XoaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XoaSP.Name = "btn_XoaSP";
            this.btn_XoaSP.Size = new System.Drawing.Size(126, 44);
            this.btn_XoaSP.TabIndex = 14;
            this.btn_XoaSP.Text = "Xóa sản phẩm";
            this.btn_XoaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaSP.UseVisualStyleBackColor = true;
            this.btn_XoaSP.Click += new System.EventHandler(this.btn_XoaSP_Click_1);
            // 
            // lb_totalcart
            // 
            this.lb_totalcart.AutoSize = true;
            this.lb_totalcart.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_totalcart.Location = new System.Drawing.Point(442, 351);
            this.lb_totalcart.Name = "lb_totalcart";
            this.lb_totalcart.Size = new System.Drawing.Size(27, 31);
            this.lb_totalcart.TabIndex = 12;
            this.lb_totalcart.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(309, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tổng tiền";
            // 
            // dtg_giohang
            // 
            this.dtg_giohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_giohang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dtg_giohang.Location = new System.Drawing.Point(6, 29);
            this.dtg_giohang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtg_giohang.Name = "dtg_giohang";
            this.dtg_giohang.RowHeadersWidth = 51;
            this.dtg_giohang.RowTemplate.Height = 25;
            this.dtg_giohang.Size = new System.Drawing.Size(569, 253);
            this.dtg_giohang.TabIndex = 0;
            this.dtg_giohang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_giohang_CellClick);
            this.dtg_giohang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_giohang_CellValueChanged);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mã SP";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tên SP";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Số Lượng";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Giá";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 749);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBanHang";
            this.Text = "Bán hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBanHang_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBanHang_FormClosed);
            this.Load += new System.EventHandler(this.FrmBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hdcho)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_giohang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox3;
        private TextBox tbt_timkSP;
        private Label label1;
        private DataGridView dtg_danhsachSP;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridView dtg_giohang;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox tbt_mahd;
        private TextBox tbt_tienkhachdua;
        private TextBox tbt_giamgia;
        private Button btn_thanhtoan;
        private RichTextBox rtb_ghichu;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label16;
        private Label lb_tienthua;
        private Label lb_tongtien;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button btn_xoaGioHang;
        private Button btn_XoaSP;
        private Label lb_totalcart;
        private Label lb_tenkh;
        private Label label10;
        private Label label9;
        private TextBox tb_sdt;
        private PictureBox pictureBox1;
        private Label label11;
        private Label lb_point;
        private Label lb_giamgia;
        private GroupBox groupBox4;
        private Button btn_capNhapHĐ;
        private DataGridView dgv_hdcho;
        private ComboBox cbb_listcamera;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column11;
    }
}