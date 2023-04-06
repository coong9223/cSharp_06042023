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
using System;
using System.Net.Mail; // this namespace is required to send emails with SMTP
using System.Net;

namespace _3._Presentation
{
    public partial class FrmLogin : Form
    {
        IQLEmployeeServices _iQLEmployee;
        public FrmLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
            _iQLEmployee = new QLEmployeeServices();
            tbt_tk.Text = Properties.Settings.Default.tk;
            tbt_mk.Text = Properties.Settings.Default.mk;
            cb_save.Checked = true;
        }

        private void tbt_tk_MouseClick(object sender, MouseEventArgs e)
        {
            tbt_tk.Text = "";
        }

        private void tbt_matk_MouseClick(object sender, MouseEventArgs e)
        {
            tbt_mk.Text = "";
        }
        public void saveInfor()
        {
            if (cb_save.Checked == true)
            {
                Properties.Settings.Default.tk = tbt_tk.Text;
                Properties.Settings.Default.mk = tbt_mk.Text;
                Properties.Settings.Default.TKdaLogin = tbt_tk.Text;
                Properties.Settings.Default.MKdaLogin = tbt_mk.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.tk = "";
                Properties.Settings.Default.mk = "";
                Properties.Settings.Default.TKdaLogin = tbt_tk.Text;
                Properties.Settings.Default.MKdaLogin = tbt_mk.Text;
                Properties.Settings.Default.Save();
            }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {

            var login = _iQLEmployee.GetEmployeeFromDB().Where(p => p.Email == tbt_tk.Text && p.Password == tbt_mk.Text).FirstOrDefault();

            if (login != null)
            {
                saveInfor();
                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");

            }
        }

        private void lb_quenmk_Click(object sender, EventArgs e)
        {
            FrmForgotPW frmForgotPW = new FrmForgotPW();
            frmForgotPW.ShowDialog();
        }
        
    }
}
