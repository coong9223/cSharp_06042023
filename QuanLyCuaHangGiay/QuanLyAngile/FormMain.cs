using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;

namespace QuanLyAngile
{
    public partial class FormMain : Form
    {
        public FormMain()
        {

            InitializeComponent();
            //FormMain_Load();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            this.Hide();
            doiMatKhau.ShowDialog();
            this.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //get data từ sql lên data grid
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã Sản Phẩm", typeof(string));
            dt.Columns.Add("Tên Sản Phẩm", typeof(string));
            dt.Columns.Add("Danh mục", typeof(string));
            dt.Columns.Add("Giá", typeof(float));
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Ngày thêm", typeof(string));

            foreach (var x in Common.db.Nhanviens)
            {
                dt.Rows.Add(x.Masanpham, x.tensanpham, x.danhmuc, x.giasanpham, x.soluong, x.ngaythem);
            }
            dgridNv.DataSource = dt;


        }

        private void dgridNv_SelectionChanged(object sender, EventArgs e)
        {

            if (dgridNv.CurrentRow != null)
            {
                tbxMsp.Text = dgridNv.CurrentRow.Cells[0].Value.ToString();
                tbxTensp.Text = dgridNv.CurrentRow.Cells[1].Value.ToString();
                tbxDanhmuc.Text = dgridNv.CurrentRow.Cells[2].Value.ToString();
                tbxGiasp.Text = dgridNv.CurrentRow.Cells[3].Value.ToString();
                tbxsoluong.Text = dgridNv.CurrentRow.Cells[4].Value.ToString();
                tbxNgayThem.Text = dgridNv.CurrentRow.Cells[5].Value.ToString();
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaNv_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            var result = tbxTimKiem.Text;
            var nv = Common.db.Nhanviens.FirstOrDefault(p => p.Masanpham == result);
            if (nv != null)
            {
                tbxMsp.Text = nv.Masanpham;
                tbxTensp.Text = nv.tensanpham;
                tbxDanhmuc.Text = nv.danhmuc;
                tbxGiasp.Text = nv.giasanpham.ToString();
                tbxsoluong.Text = nv.soluong.ToString();
                tbxNgayThem.Text = nv.ngaythem.ToString();

            }

        }

        private void btnThemNv_Click_1(object sender, EventArgs e)
        {
            var nhanVien = new Nhanvien();
            nhanVien.Masanpham = tbxMsp.Text;
            nhanVien.tensanpham = tbxTensp.Text;
            nhanVien.danhmuc = tbxDanhmuc.Text;
            nhanVien.giasanpham = int.Parse(tbxGiasp.Text);
            nhanVien.soluong = int.Parse(tbxsoluong.Text);
            nhanVien.ngaythem =DateTime.Parse( tbxNgayThem.Value.ToString());
            try
            {
                using (var db = new QuanliAngileEntities())
                {
                    db.Nhanviens.Add(nhanVien);
                    db.SaveChanges();

                }
                MessageBox.Show("thêm thành công");

            }
            catch (Exception)
            {

                MessageBox.Show("Thất Bại !!!");
            }
        }
    }
}



