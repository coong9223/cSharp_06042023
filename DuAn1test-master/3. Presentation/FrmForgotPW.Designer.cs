namespace _3._Presentation
{
    partial class FrmForgotPW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForgotPW));
            this.btn_laymk = new System.Windows.Forms.Button();
            this.tbt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_laymk
            // 
            this.btn_laymk.BackColor = System.Drawing.Color.Red;
            this.btn_laymk.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_laymk.ForeColor = System.Drawing.Color.White;
            this.btn_laymk.Location = new System.Drawing.Point(59, 413);
            this.btn_laymk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_laymk.Name = "btn_laymk";
            this.btn_laymk.Size = new System.Drawing.Size(370, 60);
            this.btn_laymk.TabIndex = 20;
            this.btn_laymk.Text = "RESET MẬT KHẨU";
            this.btn_laymk.UseVisualStyleBackColor = false;
            this.btn_laymk.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tbt_email
            // 
            this.tbt_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_email.Location = new System.Drawing.Point(59, 299);
            this.tbt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbt_email.Multiline = true;
            this.tbt_email.Name = "tbt_email";
            this.tbt_email.PlaceholderText = "Nhập email";
            this.tbt_email.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbt_email.Size = new System.Drawing.Size(370, 29);
            this.tbt_email.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quên mật khẩu";
            // 
            // ptb_logo
            // 
            this.ptb_logo.BackColor = System.Drawing.Color.Khaki;
            this.ptb_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_logo.BackgroundImage")));
            this.ptb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_logo.Location = new System.Drawing.Point(2, 3);
            this.ptb_logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(483, 165);
            this.ptb_logo.TabIndex = 15;
            this.ptb_logo.TabStop = false;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_sdt.Location = new System.Drawing.Point(58, 352);
            this.tb_sdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_sdt.Multiline = true;
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.PlaceholderText = "Nhập số điện thoại";
            this.tb_sdt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_sdt.Size = new System.Drawing.Size(370, 29);
            this.tb_sdt.TabIndex = 21;
            // 
            // FrmForgotPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(485, 528);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.btn_laymk);
            this.Controls.Add(this.tbt_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_logo);
            this.Name = "FrmForgotPW";
            this.Text = "Quên mật khẩu";
            this.Load += new System.EventHandler(this.FrmForgotPW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_laymk;
        private TextBox tbt_email;
        private Label label1;
        private PictureBox ptb_logo;
        private TextBox tb_sdt;
    }
}