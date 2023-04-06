using _2.BUS.IServices;
using _2.BUS.Services;


namespace _3._Presentation
{
    public partial class FrmMain : Form
    {
        IQLEmployeeServices _iQLEmployee;
        IQLRoleServices _iQLRole;



        public FrmMain()
        {
            InitializeComponent();
            _iQLEmployee = new QLEmployeeServices();
            _iQLRole = new QLRoleServices();
            this.CenterToScreen();
            GoFullscreen(AutoSize);
            panel_ttnv.Visible = false;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var layEmail = Properties.Settings.Default.TKdaLogin;
            var nhanvien = _iQLEmployee.GetEmployeeFromDB().FirstOrDefault(p => p.Email == layEmail);
            if (nhanvien.LinkAnh != null)
            {
                string linkanh = nhanvien.LinkAnh.Replace(@"\", @"/");
                if (File.Exists(linkanh))
                {
                    pic_avtNV.Image = Image.FromFile(linkanh);
                    pic_avtNV.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            var role = _iQLRole.GetRoleFromDB().FirstOrDefault(x => x.ID == nhanvien.IDRoles);
            lb_tenNV.Text = role.RoleName + ": " + nhanvien.FullName;
        }
        private Form activeForm;

        public void ChangeForm(Form form)
        {
            if (activeForm != null)
            {

                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            pn_main.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }



        private void btn_nv_Click(object sender, EventArgs e)
        {

            var idRole = _iQLEmployee.GetEmployeeFromDB().Where(p => p.Email == Properties.Settings.Default.TKdaLogin).Select(p => p.IDRoles).FirstOrDefault();
            if (idRole == 1)
            {
                FrmNhanVien frmNhanVien = new FrmNhanVien();
                ChangeForm(frmNhanVien);
            }
            else if (idRole != 1)
            {
                MessageBox.Show("Nhân viên không có quyền sử dụng chức năng này");
            }
            panel_ttnv.Visible = false;
        }

        private void btn_banhang_Click_1(object sender, EventArgs e)
        {
            FrmBanHang frmBanHang = new FrmBanHang();
            ChangeForm(frmBanHang);
            panel_ttnv.Visible = false;
        }

        private void btn_hoadon_Click_1(object sender, EventArgs e)
        {
            FrmHoaDon frmHoaDon = new FrmHoaDon();
            ChangeForm(frmHoaDon);
            panel_ttnv.Visible = false;
        }

        private void btn_sp_Click(object sender, EventArgs e)
        {
            FrmQuanLy frmQuanLy = new FrmQuanLy();
            ChangeForm(frmQuanLy);
            panel_ttnv.Visible = false;
        }

        private void btn_thongke_Click_1(object sender, EventArgs e)
        {
            FrmThongKe frmThongKe = new FrmThongKe();
            ChangeForm(frmThongKe);
            panel_ttnv.Visible = false;
        }
        int x = 260; int y = 20; int a = 1;
        private void timerChayChu_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                labelChaychu.Location = new Point(x, y);
                if (x >= 660)
                {
                    a = -2;
                }
                if (x <= 260)
                {
                    a = 2;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pcb_avtNV_Click(object sender, EventArgs e)
        {
            var nhanvien = _iQLEmployee.GetEmployeeFromDB().FirstOrDefault(p => p.Email == Properties.Settings.Default.TKdaLogin);

            lb_maNV.Text = nhanvien.MaNV.ToString();
            labe_ten.Text = nhanvien.FullName;
            label_sdt.Text = nhanvien.Phone;
            label_email.Text = nhanvien.Email;
            label_gioitinh.Text = nhanvien.Sex == true ? "Nam" : "Nữ";
            string formattedDate = nhanvien.Dob.ToString("dd-MM-yyyy");  //chuyển đổi sang dd/mm/yyyy 
            label_ngaysinh.Text = Convert.ToString(formattedDate);
            label_diachi.Text = nhanvien.Address;

            panel_ttnv.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin logibn = new FrmLogin();
            logibn.ShowDialog();
            this.Close();
        }

        private void button_doimk_Click(object sender, EventArgs e)
        {
            var mk = _iQLEmployee.GetEmployeeFromDB().FirstOrDefault(p => p.Password == textBox_mkcu.Text);
            if (mk == null)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác");

            }
            else if (textBox_mkmoi.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự");

            }
            else if (textBox_nhaplaimk.Text != textBox_mkmoi.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác");
            }


            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi mật khẩu không ?", "Thông Báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var mkmoi = _iQLEmployee.GetEmployeeFromDB().FirstOrDefault();
                    mkmoi.Password = textBox_mkmoi.Text;
                    _iQLEmployee.UpdateEmployee(mkmoi);
                    MessageBox.Show("Đổi mật khẩu thành công");



                }

                this.Hide();
                FrmLogin login = new FrmLogin();
                login.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                //this.Close();
            }
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            FrmKhachHang frmKhachHang = new FrmKhachHang();
            ChangeForm(frmKhachHang);
            panel_ttnv.Visible = false;
        }
    }
}