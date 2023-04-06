using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._Presentation
{
    public partial class FrmForgotPW : Form
    {
        private IQLEmployeeServices _employee;
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void MailSendThruGmail(string email,string pw)
        {
            MailAddress fromAddress = new MailAddress("thangnmph18817@fpt.edu.vn", "Admin");
            MailAddress toAddress = new MailAddress(email, "User");
            const string subject = "Reset mật khẩu App BeeMart";
            string body = @"Bạn đã yêu cầu đổi mật khẩu. Mật khẩu mới của bạn là: <b>" + pw + "</b>";

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage(fromAddress.Address, toAddress.Address, subject, body);
            msg.IsBodyHtml = true;

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("thangnmph18817@fpt.edu.vn", "thangnm96"),
                EnableSsl = true
            };

            try
            {
                client.Send(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public FrmForgotPW()
        {
            InitializeComponent();
            _employee = new QLEmployeeServices();
            this.CenterToScreen();
        }

        private void FrmForgotPW_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var em = _employee.GetEmployeeFromDB().FirstOrDefault(x => x.Email == tbt_email.Text && x.Phone == tb_sdt.Text);
            if (em == null)
            {
                MessageBox.Show("Khum tìm thấy email và số điện thoại trùng khớp. Vui lòng kiểm tra lại");
            }
            else
            {
                string random = RandomString(6);
                em.Password = random;
                _employee.UpdateEmployee(em);

                MailSendThruGmail(tbt_email.Text, random);
                MessageBox.Show("Reset mật khẩu thành công. Vui lòng kiểm tra email");
                this.Close();
            }
        }
    }
}
