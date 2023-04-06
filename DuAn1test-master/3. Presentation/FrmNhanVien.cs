using _1.DAL.Entities;
using System.IO;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _3._Presentation
{
    public partial class FrmNhanVien : Form
    {
        IQLEmployeeServices _iQLEmployee;
        IQLRoleServices _iQLRole;
        string linkAnh = "";
        string layEmail = "";
        Employee employee;

        public FrmNhanVien()
        {
            InitializeComponent();
            _iQLEmployee = new QLEmployeeServices();
            _iQLRole = new QLRoleServices();
            foreach (var item in _iQLRole.GetRoleFromDB())
            {
                cbb_chucvu.Items.Add(item.RoleName);
            }
            rad_hd.Checked = true;
            rb_nam.Checked = true;
            foreach (var item in _iQLRole.GetRoleFromDB())
            {
                cbb_locChucVu.Items.Add(item.RoleName);
            }
            cbb_locTrangThai.Items.Add("Hoạt Động");
            cbb_locTrangThai.Items.Add("Không hoạt Động");
            dtp_ngaysinh.CustomFormat = "dd-MM-yyyy";
            loadNhanVien();

        }
        public bool checkInput()
        {
            string email = tbt_Email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,10})+)$");
            Match match = regex.Match(email);
            if (!match.Success)
            {
                MessageBox.Show("Email không hợp lệ!!!");
                tbt_Email.Text = "";
                return false;
            }
            else if (tbt_tenNV.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập Tên nhân viên");
                return false;
            }
            else if (tbt_tenNV.Text.Length < 8)
            {
                MessageBox.Show("Tên nhân viên phải có ít nhất 8 kí tự");
                return false;
            }
            else if (tbt_sdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải có ít nhất 10 kí tự");
                return false;
            }
            else if (!tbt_sdt.Text.All(char.IsNumber))
            {
                MessageBox.Show("Số điện thoại phải là số !");
                return false;
            }
            else if (tbt_diachi.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ !");
                return false;
            }
            else if (pictureBox_avt.Image == null)
            {
                MessageBox.Show("Bạn chưa tải ảnh đại diện !");
                return false;
            }

            return true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            var checkEmail = _iQLEmployee.GetEmployeeFromDB().FirstOrDefault(p => p.Email == tbt_Email.Text);
            if (!checkInput())
            {

            }
            else
            {
                if (checkEmail != null)
                {
                    MessageBox.Show("Email đã được sử dụng, hãy chọn Email khác");
                }
                else
                {
                    int idss = _iQLEmployee.GetEmployeeFromDB().Count() + 1;

                    // This will get the current PROJECT directory
                    string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                    File.Copy(linkAnh, Path.Combine(projectDirectory, "Resources", "Employee", Path.GetFileName(linkAnh)), true);
                    linkAnh = Path.Combine(projectDirectory, "Resources", "Employee", Path.GetFileName(linkAnh));
                    //MessageBox.Show(linkAnh);

                    Employee employeee = new Employee()
                    {

                        MaNV = "NV" + idss,
                        Email = tbt_Email.Text,
                        Password = "123",
                        FullName = tbt_tenNV.Text,
                        Status = rad_hd.Checked,
                        Sex = rb_nam.Checked,
                        Dob = dtp_ngaysinh.Value,
                        Address = tbt_diachi.Text,
                        Phone = tbt_sdt.Text,
                        IDRoles = cbb_chucvu.Text == "Quản lý" ? 1 : 2,
                        LinkAnh = linkAnh
                    };
                    _iQLEmployee.AddEmployee(employeee);
                    MessageBox.Show("Thêm Nhân Viên thành công");
                    loadNhanVien();
                }
            }

        }

        public void loadNhanVien()
        {
            dgv_nhanvien.Rows.Clear();
            foreach (var item in _iQLEmployee.GetEmployeeFromDB())
            {
                string formattedDate = item.Dob.ToString("dd-MM-yyyy");  //chuyển đổi sang dd/mm/yyyy 

                dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                    _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                    item.Status == true ? "Hoạt Động" : "Không hoạt động",
                    item.Dob.ToString("dd-MM-yyyy"));
            }
            cbb_chucvu.SelectedIndex = 1;
        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgv_nhanvien.Rows[e.RowIndex];
            employee = _iQLEmployee.GetEmployeeFromDB().FirstOrDefault(p => p.MaNV == r.Cells[0].Value.ToString());
            tbt_tenNV.Text = r.Cells[1].Value.ToString();
            tbt_sdt.Text = r.Cells[2].Value.ToString();
            rb_nam.Checked = r.Cells[4].Value.ToString() == "Nam" ? true : false;
            rb_nu.Checked = r.Cells[4].Value.ToString() == "Nữ" ? true : false;

            //dtp_ngaysinh.Value = Convert.ToDateTime(r.Cells[7].Value);
            dtp_ngaysinh.Value = employee.Dob;
            tbt_Email.Text = employee.Email;
            cbb_chucvu.Text = r.Cells[5].Value.ToString();
            tbt_diachi.Text = r.Cells[3].Value.ToString();
            rad_hd.Checked = r.Cells[6].Value.ToString() == "Hoạt Động" ? true : false;
            rad_khd.Checked = r.Cells[6].Value.ToString() == "Không hoạt động" ? true : false;
            linkAnh = employee.LinkAnh;
            layEmail = tbt_Email.Text;
            if (linkAnh != null && File.Exists(linkAnh))
            {
                pictureBox_avt.Image = Image.FromFile(linkAnh);
                pictureBox_avt.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox_avt.Image = null;
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            var up = _iQLEmployee.GetEmployeeFromDB().FirstOrDefault(p => p.Email == layEmail);
            if (tbt_Email.Text != layEmail)
            {
                MessageBox.Show("Bạn không được thay đổi Email");
                tbt_Email.Text = layEmail;
            }
            else
            {
                if (!checkInput())
                {

                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn cập nhật thông tin không ?", "Thông Báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (employee.LinkAnh != linkAnh)
                        {
                            // This will get the current PROJECT directory
                            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                            File.Copy(linkAnh, Path.Combine(projectDirectory, "Resources", "Employee", Path.GetFileName(linkAnh)), true);
                            linkAnh = Path.Combine(projectDirectory, "Resources", "Employee", Path.GetFileName(linkAnh));
                            //MessageBox.Show(linkAnh);
                        }

                        employee.FullName = tbt_tenNV.Text;
                        employee.Sex = rb_nam.Checked;
                        employee.Dob = dtp_ngaysinh.Value;
                        employee.IDRoles = cbb_chucvu.Text == "Quản lý" ? 1 : 2;
                        employee.Address = tbt_diachi.Text;
                        employee.Phone = tbt_sdt.Text;
                        employee.Status = rad_hd.Checked;
                        employee.LinkAnh = linkAnh;
                        if (employee.Email == tbt_Email.Text)
                        {
                            _iQLEmployee.UpdateEmployee(employee);
                            MessageBox.Show("Cập nhật thông tin thành công");


                            loadNhanVien();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin thất bại");
                        }
                    }

                }
            }


        }
        private void pictureBox_avt_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                linkAnh = op.FileName;
                pictureBox_avt.Image = Image.FromFile(op.FileName);
                pictureBox_avt.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void textBox_timKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbb_locChucVu.Text != "")
            {
                if (cbb_locTrangThai.Text == "Hoạt Động")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.FullName.Contains(textBox_timKiem.Text)
                                                                      && p.IDRoles == cbb_locChucVu.SelectedIndex + 1 && p.Status == true);
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }
                if (cbb_locTrangThai.Text == "Không koạt Động")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.FullName.Contains(textBox_timKiem.Text)
                                                                           && p.IDRoles == cbb_locChucVu.SelectedIndex + 1 && p.Status == false);
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }
                if (cbb_locTrangThai.Text == "")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.FullName.Contains(textBox_timKiem.Text)
                                                                           && p.IDRoles == cbb_locChucVu.SelectedIndex + 1);
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }


            }
            if (cbb_locChucVu.Text == "")
            {
                if (cbb_locTrangThai.Text == "Hoạt Động")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.FullName.Contains(textBox_timKiem.Text)
                                                                            && p.Status == true);
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }
                if (cbb_locTrangThai.Text == "Không koạt Động")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.FullName.Contains(textBox_timKiem.Text)
                                                                            && p.Status == false);
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }

                if (cbb_locTrangThai.Text == "")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.FullName.Contains(textBox_timKiem.Text));
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }

            }
            if (cbb_locTrangThai.Text == "Hoạt Động")
            {
                if (cbb_chucvu.Text == "")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.FullName.Contains(textBox_timKiem.Text)
                                                                              && p.Status == true);
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }
            }
            if (cbb_locTrangThai.Text == "Không hoạt Động")
            {
                if (cbb_chucvu.Text == "")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.FullName.Contains(textBox_timKiem.Text)
                                                                              && p.Status == false);
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }
            }

        }

        private void cbb_locTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_locTrangThai.Text == "Hoạt Động" && cbb_locChucVu.Text != "")
            {
                if (textBox_timKiem.Text != "")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.Status == true
                                                                              && p.IDRoles == cbb_locChucVu.SelectedIndex + 1
                                                                              && p.FullName.Contains(textBox_timKiem.Text));
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }
                if (textBox_timKiem.Text == "")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.Status == true
                                                                           && p.IDRoles == cbb_locChucVu.SelectedIndex + 1);
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }

            }
            if (cbb_locTrangThai.Text == "Không hoạt Động" && cbb_locChucVu.Text != "")
            {
                if (textBox_timKiem.Text != "")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.Status == false
                                                                           && p.IDRoles == cbb_locChucVu.SelectedIndex + 1
                                                                           && p.FullName.Contains(textBox_timKiem.Text));
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }
                if (textBox_timKiem.Text == "")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.Status == false
                                                                           && p.IDRoles == cbb_locChucVu.SelectedIndex + 1);
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }
            }
            if (cbb_locTrangThai.Text == "Hoạt Động" && cbb_locChucVu.Text == "")
            {
                if (textBox_timKiem.Text != "")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.Status == true
                                                                           && p.FullName.Contains(textBox_timKiem.Text));
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }
                if (textBox_timKiem.Text == "")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.Status == true);
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }
            }
            if (cbb_locTrangThai.Text == "Không hoạt Động" && cbb_locChucVu.Text == "")
            {
                if (textBox_timKiem.Text != "")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.Status == false
                                                                           && p.FullName.Contains(textBox_timKiem.Text));
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }
                if (textBox_timKiem.Text == "")
                {
                    var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.Status == false);
                    dgv_nhanvien.Rows.Clear();
                    foreach (var item in timkiem)
                    {
                        dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                             _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                             item.Status == true ? "Hoạt Động" : "Không hoạt động",
                             item.Dob.ToString("dd-MM-yyyy"));
                    }
                }

            }


        }

        private void cbb_locChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox_timKiem.Text == "")
            {
                var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.IDRoles == cbb_locChucVu.SelectedIndex + 1);

                dgv_nhanvien.Rows.Clear();
                foreach (var item in timkiem)
                {
                    dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                         _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                         item.Status == true ? "Hoạt Động" : "Không hoạt động",
                         item.Dob.ToString("dd-MM-yyyy"));
                }
            }
            if (textBox_timKiem.Text != "")
            {
                var timkiem = _iQLEmployee.GetEmployeeFromDB().Where(p => p.IDRoles == cbb_locChucVu.SelectedIndex + 1 && p.FullName.Contains(textBox_timKiem.Text));

                dgv_nhanvien.Rows.Clear();
                foreach (var item in timkiem)
                {
                    dgv_nhanvien.Rows.Add(item.MaNV, item.FullName, item.Phone, item.Address, item.Sex == true ? "Nam" : "Nữ",
                         _iQLRole.GetRoleFromDB().Where(p => p.ID == item.IDRoles).Select(p => p.RoleName).FirstOrDefault(),
                         item.Status == true ? "Hoạt Động" : "Không hoạt động",
                         item.Dob.ToString("dd-MM-yyyy"));
                }
            }



        }

        private void button_rset_Click(object sender, EventArgs e)
        {
            loadNhanVien();
            cbb_locChucVu.Text = "";
            cbb_locTrangThai.Text = "";
            textBox_timKiem.Text = "";
        }
    }
}
