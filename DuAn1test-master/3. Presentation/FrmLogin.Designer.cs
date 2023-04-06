namespace _3._Presentation
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_quenmk = new System.Windows.Forms.Label();
            this.tbt_mk = new System.Windows.Forms.TextBox();
            this.tbt_tk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_save = new System.Windows.Forms.CheckBox();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Red;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(54, 481);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(370, 60);
            this.btn_login.TabIndex = 13;
            this.btn_login.Text = "ĐĂNG NHẬP";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lb_quenmk
            // 
            this.lb_quenmk.AutoSize = true;
            this.lb_quenmk.ForeColor = System.Drawing.Color.Red;
            this.lb_quenmk.Location = new System.Drawing.Point(317, 400);
            this.lb_quenmk.Name = "lb_quenmk";
            this.lb_quenmk.Size = new System.Drawing.Size(116, 20);
            this.lb_quenmk.TabIndex = 12;
            this.lb_quenmk.Text = "Quên mật khẩu?";
            this.lb_quenmk.Click += new System.EventHandler(this.lb_quenmk_Click);
            // 
            // tbt_mk
            // 
            this.tbt_mk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_mk.Location = new System.Drawing.Point(54, 341);
            this.tbt_mk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_mk.Multiline = true;
            this.tbt_mk.Name = "tbt_mk";
            this.tbt_mk.PasswordChar = '*';
            this.tbt_mk.PlaceholderText = "Nhập mật khẩu";
            this.tbt_mk.Size = new System.Drawing.Size(370, 29);
            this.tbt_mk.TabIndex = 11;
            this.tbt_mk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbt_matk_MouseClick);
            // 
            // tbt_tk
            // 
            this.tbt_tk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_tk.Location = new System.Drawing.Point(54, 281);
            this.tbt_tk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_tk.Multiline = true;
            this.tbt_tk.Name = "tbt_tk";
            this.tbt_tk.PlaceholderText = "Nhập tài khoản";
            this.tbt_tk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbt_tk.Size = new System.Drawing.Size(370, 29);
            this.tbt_tk.TabIndex = 10;
            this.tbt_tk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbt_tk_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // cb_save
            // 
            this.cb_save.AutoSize = true;
            this.cb_save.BackColor = System.Drawing.Color.Khaki;
            this.cb_save.ForeColor = System.Drawing.Color.Red;
            this.cb_save.Location = new System.Drawing.Point(61, 400);
            this.cb_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_save.Name = "cb_save";
            this.cb_save.Size = new System.Drawing.Size(124, 24);
            this.cb_save.TabIndex = 14;
            this.cb_save.Text = "Nhớ mật khẩu";
            this.cb_save.UseVisualStyleBackColor = false;
            // 
            // ptb_logo
            // 
            this.ptb_logo.BackColor = System.Drawing.Color.Khaki;
            this.ptb_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_logo.BackgroundImage")));
            this.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_logo.Location = new System.Drawing.Point(-2, -1);
            this.ptb_logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(489, 163);
            this.ptb_logo.TabIndex = 8;
            this.ptb_logo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(485, 591);
            this.Controls.Add(this.cb_save);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb_quenmk);
            this.Controls.Add(this.tbt_mk);
            this.Controls.Add(this.tbt_tk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_logo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLogin";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_login;
        private Label lb_quenmk;
        private TextBox tbt_mk;
        private TextBox tbt_tk;
        private Label label1;
        private CheckBox cb_save;
        private PictureBox ptb_logo;
    }
}