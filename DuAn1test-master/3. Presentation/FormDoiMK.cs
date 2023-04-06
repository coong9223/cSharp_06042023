using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._Presentation
{
    public partial class FormDoiMK : Form
    {
        IQLEmployeeServices _iQLEmployee;
        public FormDoiMK()
        {

            InitializeComponent();
            this.CenterToScreen();
            _iQLEmployee = new QLEmployeeServices();
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
                    MessageBox.Show("Đổi mật khẩu thành công. Vui lòng đăng nhập lại");
                }
                //this.Hide();
                //Application.Exit();
                FrmMain m = new FrmMain();
                this.Close();
                
                FrmLogin login = new FrmLogin();
                login.ShowDialog();
                //this.Close();
            }
        }
    }
}
