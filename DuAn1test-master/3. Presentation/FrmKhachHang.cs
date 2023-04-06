using _1.DAL.Entities;
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
    public partial class FrmKhachHang : Form
    {
        private IQLCustomerServices _qlCustomerServices;
        private Customer _customer;
        string sdt = "";
        public FrmKhachHang()
        {
            _qlCustomerServices = new QLCustomerServices();
            _customer = new Customer();
            
            InitializeComponent();
            rb_nam.Checked = true;
            loaddata();
        }
        private bool checknhap()
        {
            if(tbt_KH.Text == "" || tbt_sdt.Text == "" || tbt_diachi.Text == "")
            {
                return false;
            }
            return true;
        }
        private void loaddata()
        {
            dataGridView1.ColumnCount = 6;

            dataGridView1.Columns[0].Name = "Mã Khách Hàng";
            dataGridView1.Columns[1].Name = "Tên Khách Hàng";
            dataGridView1.Columns[2].Name = "Số Điện Thoại";
            dataGridView1.Columns[3].Name = "Giới Tính";
            dataGridView1.Columns[4].Name = "Địa Chỉ";
            dataGridView1.Columns[5].Name = "Điểm";
            dataGridView1.Rows.Clear();
            foreach(var item in _qlCustomerServices.GetCustomerFromDB())
            {
                dataGridView1.Rows.Add(item.ID,item.Name,item.Phone,item.Sex == true ? "Nam" : "Nữ",item.Address,item.Point);
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            var sdt = _qlCustomerServices.GetCustomerFromDB().FirstOrDefault(p => p.Phone == tbt_sdt.Text);
            if(checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else if (tbt_sdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải có ít nhất 10 kí tự");

            }
            else if(sdt != null)
            {
                MessageBox.Show("Số điện thoại đã được sử dụng", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn cập nhật sản phẩm không?", "Chú ý", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    _customer.Name = tbt_KH.Text;
                    _customer.Phone = tbt_sdt.Text;
                    _customer.Address = tbt_diachi.Text;
                    _customer.Sex = rb_nam.Checked == true ? true : false;
                    _customer.Point = 10000;
                    _qlCustomerServices.AddCustomer(_customer);
                    loaddata();
                    MessageBox.Show("Thêm khách hàng thành công");
                }


            }
            
        }

        private void tbt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            
            var _sdt = _qlCustomerServices.GetCustomerFromDB().FirstOrDefault(p=>p.Phone == tbt_sdt.Text);
            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else if (tbt_sdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải có ít nhất 10 kí tự");

            }
            else if (sdt != tbt_sdt.Text  && _sdt != null)
            {
                MessageBox.Show("Số điện thoại đã được sử dụng", "Chú ý");
            }
            else
            {

                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn cập nhật sản phẩm không?", "Chú ý", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {

                    _customer.Name = tbt_KH.Text;
                    _customer.Phone = tbt_sdt.Text;
                    _customer.Address = tbt_diachi.Text;
                    _customer.Sex = rb_nam.Checked == true ? true : false;
                    _qlCustomerServices.UpdateCustomer(_customer);
                    loaddata();
                    sdt = tbt_sdt.Text;
                    MessageBox.Show("Sửa khách hàng thành công");
                }

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
                _customer = _qlCustomerServices.GetCustomerFromDB().FirstOrDefault(p => p.ID.ToString() == r.Cells[0].Value.ToString());
                if (_customer != null)
                {
                    tbt_KH.Text = _customer.Name;
                    tbt_sdt.Text = _customer.Phone;
                    tbt_diachi.Text = _customer.Address;
                    
                    
                    if (_customer.Sex == true)
                    {
                        rb_nam.Checked = true;
                        rb_nu.Checked = false;
                    }
                    else
                    {
                        rb_nu.Checked = true;
                        rb_nam.Checked = false;
                    }
                    
                    sdt = tbt_sdt.Text;
                }
            }
        }

        private void tbt_timkKH_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;

            dataGridView1.Columns[0].Name = "Mã Khách Hàng";
            dataGridView1.Columns[1].Name = "Tên Khách Hàng";
            dataGridView1.Columns[2].Name = "Số Điện Thoại";
            dataGridView1.Columns[3].Name = "Giới Tính";
            dataGridView1.Columns[4].Name = "Địa Chỉ";
            dataGridView1.Columns[5].Name = "Điểm";
            dataGridView1.Rows.Clear();
            foreach (var item in _qlCustomerServices.GetCustomerFromDB().Where(x=>x.Name.ToLower().Contains(tbt_timkKH.Text.ToLower()) || x.Phone.Contains(tbt_timkKH.Text) ))
            {
                dataGridView1.Rows.Add(item.ID, item.Name, item.Phone, item.Sex == true ? "Nam" : "Nữ", item.Address, item.Point);
            }
        }
    }
}
