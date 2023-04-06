using _1.DAL.Entities;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace _3._Presentation
{
    public partial class FrmSanPham : Form
    {
        public IQLProductServices _IQLProductServices;
        public IQLProducerServices _IQLProducerServices;
        public ICategoryService _CategoryrServices;

        public Product _product;
        string linkavatar = "";
        string tensp = "";

        public FrmSanPham()
        {
            InitializeComponent();
            _product = new Product();
            _IQLProductServices = new QLProductServices();
            _IQLProducerServices = new QLProducerServises();
            _CategoryrServices = new CategoryService();
            rd_kd.Checked = true;
            this.CenterToScreen();
            LoadData();
            LoadLoaiHang();
            LoadNhaSanXuat();

        }
        public void LoadNhaSanXuat()
        {
            var nsx = _IQLProducerServices.GetProducerFromDB();
            foreach (var item in nsx)
            {
                cbb_nhasanxuat.Items.Add(item.Name);
            }
        }
        public void LoadLoaiHang()
        {
            var lh = _CategoryrServices.GetCategoryFromDB();
            foreach (var item in lh)
            {
                cbb_loaihang.Items.Add(item.Name);
            }
        }
        public void LoadData()
        {

            dtgv_frmSP.ColumnCount = 9;
            dtgv_frmSP.Columns[0].Name = "Mã SP";
            dtgv_frmSP.Columns[1].Name = "Tên SP";
            dtgv_frmSP.Columns[2].Name = "Loại SP";
            dtgv_frmSP.Columns[3].Name = "Nhà sản xuất";
            dtgv_frmSP.Columns[4].Name = "Số lượng";
            dtgv_frmSP.Columns[5].Name = "Giá nhập";
            dtgv_frmSP.Columns[6].Name = "Giá bán";
            dtgv_frmSP.Columns[7].Name = "Trạng thái";
            dtgv_frmSP.Columns[8].Name = "Ghi chú";
            dtgv_frmSP.Rows.Clear();
            var data = (from a in _IQLProductServices.GetProductFromDB()
                        join b in _IQLProducerServices.GetProducerFromDB() on a.ProducerID equals b.ID
                        join c in _CategoryrServices.GetCategoryFromDB() on a.CategoryID equals c.ID
                        select new ProductVm
                        {
                            Id = a.MaSp,
                            Name = a.Name,
                            ProducerName = b.Name,
                            CategoryName = c.Name,
                            Stock = a.Stock,
                            OriginalPrice = a.OriginalPrice,
                            Price = a.Price,
                            Status = a.Status == true ? "Kinh doanh" : "Ngưng kinh doanh",
                            Note = a.Note
                        }).ToList();

            foreach (var item in data)
            {
                dtgv_frmSP.Rows.Add(item.Id, item.Name, item.CategoryName, item.ProducerName, item.Stock, item.OriginalPrice, item.Price, item.Status, item.Note);
            }


        }
        public bool checknhap()
        {
            if (tbt_maSP.Text == "" || tb_tensp.Text == "" || tbt_gianhap.Text == "" || tbt_giaban.Text == "" || tbt_stock.Text == "" || cbb_nhasanxuat.Text == "" || cbb_loaihang.Text == "") return false;
            return true;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            var p = _IQLProductServices.GetProductFromDB().FirstOrDefault(x => x.MaSp == tbt_maSP.Text);
            var tsp = _IQLProductServices.GetProductFromDB().FirstOrDefault(p => p.Name == tb_tensp.Text);
            int gn, gb;

            if (checknhap() == false)
            {
                MessageBox.Show("Không được để trống các trường", "Chú ý");
            }
            else if (p != null)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại", "Chú ý");
            }
            else if (tsp != null)
            {
                MessageBox.Show("Tên sản phẩm đã tồn tại", "Chú ý");
            }
            else if (Convert.ToDecimal(tbt_gianhap.Text) > Convert.ToDecimal(tbt_giaban.Text))
            {
                MessageBox.Show("Giá bán phải cao hơn giá nhập", "Chú ý");
            }
            else if (linkavatar == "")
            {
                MessageBox.Show("Bạn chưa thêm ảnh cho sản phẩm", "Chú ý");
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                DialogResult dialog = MessageBox.Show("Bạn có muốn thêm sản phẩm không?", "Thêm", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {


                    string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                    File.Copy(linkavatar, Path.Combine(projectDirectory, "Resources", "Product", Path.GetFileName(linkavatar)), true);
                    linkavatar = Path.Combine(projectDirectory, "Resources", "Product", Path.GetFileName(linkavatar));
                    _product = new Product();
                    _product.MaSp = tbt_maSP.Text;
                    _product.Name = tb_tensp.Text;
                    _product.OriginalPrice = Convert.ToDecimal(tbt_gianhap.Text);
                    _product.Price = Convert.ToDecimal(tbt_giaban.Text);
                    _product.Stock = Convert.ToInt32(tbt_stock.Text);
                    _product.ProducerID = cbb_nhasanxuat.SelectedIndex + 1;
                    _product.CategoryID = cbb_loaihang.SelectedIndex + 1;
                    _product.DateCreated = DateTime.Now;
                    _product.LinkImage = linkavatar;
                    _product.Note = tb_ghichu.Text;
                    _product.Status = rd_kd.Checked == true ? true : false;
                    _IQLProductServices.AddProduct(_product);
                    MessageBox.Show("Thêm sản phẩm thành công");

                    LoadData();


                }

            }



        }
        private void FrmSanPham_Load(object sender, EventArgs e)
        {
        }


        private void FrmSanPham_FormClosed(object sender, FormClosedEventArgs e)
        {
        }



        private void pcb_anhSP_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (pcb_anhSP.Image != null)
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn đổi ảnh không", "Some tite", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (op.ShowDialog() == DialogResult.OK)
                    {
                        pcb_anhSP.Image = Image.FromFile(op.FileName);
                        pcb_anhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                        linkavatar = op.FileName;
                    }

                }
            }
            else
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    pcb_anhSP.Image = Image.FromFile(op.FileName);
                    pcb_anhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                    linkavatar = op.FileName;
                }
            }
        }


        private void tbt_gianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbt_giaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            _product = _IQLProductServices.GetProductFromDB().FirstOrDefault(p => p.MaSp == tbt_maSP.Text);
            if (_product == null)
            {
                MessageBox.Show("Không tìm thấy mã sản phẩm", "Cảnh báo");
            }
            else
            {
                var tsp = _IQLProductServices.GetProductFromDB().FirstOrDefault(p => p.Name == tb_tensp.Text);


                if (checknhap() == false)
                {
                    MessageBox.Show("Không được để trống các trường", "Chú ý");
                }
                else if (tensp != tb_tensp.Text && tsp != null)
                {
                    MessageBox.Show("Tên sản phẩm đã tồn tại", "Chú ý");
                }
                else if (Convert.ToDecimal(tbt_gianhap.Text) > Convert.ToDecimal(tbt_giaban.Text))
                {
                    MessageBox.Show("Giá bán phải cao hơn giá nhập", "Chú ý");
                }
                else if (pcb_anhSP.Image == null)
                {
                    MessageBox.Show("Bạn chưa thêm ảnh cho sản phẩm", "Chú ý");
                }
                else
                {
                    OpenFileDialog op = new OpenFileDialog();
                    DialogResult dialog = MessageBox.Show("Bạn có muốn cập nhật sản phẩm không?", "Chú ý", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        if (linkavatar != _product.LinkImage)
                        {
                            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                            File.Copy(linkavatar, Path.Combine(projectDirectory, "Resources", "Product", Path.GetFileName(linkavatar)), true);
                            linkavatar = Path.Combine(projectDirectory, "Resources", "Product", Path.GetFileName(linkavatar));
                        }
                        _product.Name = tb_tensp.Text;
                        _product.OriginalPrice = Convert.ToDecimal(tbt_gianhap.Text);
                        _product.Price = Convert.ToDecimal(tbt_giaban.Text);
                        _product.Stock = Convert.ToInt32(tbt_stock.Text);
                        _product.ProducerID = cbb_nhasanxuat.SelectedIndex + 1;
                        _product.CategoryID = cbb_loaihang.SelectedIndex + 1;
                        _product.DateCreated = DateTime.Now;
                        _product.LinkImage = linkavatar;
                        _product.Note = tb_ghichu.Text;
                        _product.Status = rd_kd.Checked == true ? true : false;
                        _IQLProductServices.UpdateProduct(_product);
                        MessageBox.Show("Cập nhật sản phẩm thành công");
                        LoadData();
                        tensp = tb_tensp.Text;
                    }
                }
            }
        }

        private void dtgv_frmSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtgv_frmSP.Rows[e.RowIndex];
                var data = _IQLProductServices.GetProductFromDB().FirstOrDefault(p => p.MaSp.ToString() == r.Cells[0].Value.ToString());
                if (data != null)
                {
                    tbt_maSP.Text = data.MaSp;
                    tb_tensp.Text = data.Name;
                    tbt_gianhap.Text = data.OriginalPrice.ToString();
                    tbt_giaban.Text = data.Price.ToString();
                    tbt_stock.Text = data.Stock.ToString();
                    cbb_loaihang.SelectedIndex = data.CategoryID - 1;
                    cbb_nhasanxuat.SelectedIndex = data.ProducerID - 1;
                    if (data.Status == true)
                    {
                        rd_kd.Checked = true;
                        rd_ngungkd.Checked = false;
                    }
                    else
                    {
                        rd_ngungkd.Checked = true;
                        rd_kd.Checked = false;
                    }
                    tb_ghichu.Text = data.Note;
                    if (data.LinkImage != null && File.Exists(data.LinkImage))
                    {
                        pcb_anhSP.Image = Image.FromFile(data.LinkImage);
                        pcb_anhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                        linkavatar = data.LinkImage;
                    }
                    else
                    {

                        pcb_anhSP.Image = null;
                    }
                    tensp = tb_tensp.Text;
                }
            }
        }

        private void tbt_timkSP_TextChanged(object sender, EventArgs e)
        {
            dtgv_frmSP.Rows.Clear();
            var data = (from a in _IQLProductServices.GetProductFromDB()
                        join b in _IQLProducerServices.GetProducerFromDB() on a.ProducerID equals b.ID
                        join c in _CategoryrServices.GetCategoryFromDB() on a.CategoryID equals c.ID
                        where a.Name.ToLower().Contains(tbt_timkSP.Text.ToLower())
                        select new ProductVm
                        {
                            Id = a.MaSp,
                            Name = a.Name,
                            ProducerName = b.Name,
                            CategoryName = c.Name,
                            Stock = a.Stock,
                            OriginalPrice = a.OriginalPrice,
                            Price = a.Price,
                            Status = a.Status == true ? "Kinh doanh" : "Ngưng kinh doanh",
                            Note = a.Note
                        }).ToList();

            foreach (var item in data)
            {
                dtgv_frmSP.Rows.Add(item.Id, item.Name, item.CategoryName, item.ProducerName, item.Stock, item.OriginalPrice, item.Price, item.Status, item.Note);
            }
        }


        public void showSpDaTonTai(string masp)
        {
            var p = _IQLProductServices.GetProductFromDB().FirstOrDefault(x => x.MaSp == masp);
            if (p != null)
            {
                DialogResult dialogResult = MessageBox.Show("Mã sản phẩm đã tồn tại. Bạn có muốn cập nhật sản phẩm không?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    tbt_maSP.Text = p.MaSp;
                    tb_tensp.Text = p.Name;
                    tbt_gianhap.Text = p.OriginalPrice.ToString();
                    tbt_giaban.Text = p.Price.ToString();
                    tbt_stock.Text = p.Stock.ToString();
                    cbb_loaihang.SelectedIndex = p.CategoryID - 1;
                    cbb_nhasanxuat.SelectedIndex = p.ProducerID - 1;
                    tb_ghichu.Text = p.Note;
                    if (p.Status == true)
                    {
                        rd_kd.Checked = true;
                        rd_ngungkd.Checked = false;
                    }
                    else
                    {
                        rd_ngungkd.Checked = true;
                        rd_kd.Checked = false;
                    }
                    if (p.LinkImage != null && File.Exists(p.LinkImage))
                    {
                        pcb_anhSP.Image = Image.FromFile(p.LinkImage);
                        pcb_anhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                        linkavatar = p.LinkImage;
                    }
                    else
                    {
                        pcb_anhSP.Image = null;
                    }
                    //do something
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        //public void suaSpDaTonTai()
        //{
        //    var p = _IQLProductServices.GetProductFromDB().FirstOrDefault(x => x.MaSp == tbt_maSP.Text);
        //    if (p != null)
        //    {
        //        DialogResult dialogResult = MessageBox.Show("Mã sản phẩm đã tồn tại. Bạn có muốn cập nhật sản phẩm không?", "Some Title", MessageBoxButtons.YesNo);
        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        //            File.Copy(linkavatar, Path.Combine(projectDirectory, "Resources", "Product", Path.GetFileName(linkavatar)), true);
        //            linkavatar = Path.Combine(projectDirectory, "Resources", "Product", Path.GetFileName(linkavatar));
        //            _product.Name = tb_tensp.Text;
        //            _product.OriginalPrice = Convert.ToDecimal(tbt_gianhap.Text);
        //            _product.Price = Convert.ToDecimal(tbt_giaban.Text);
        //            _product.Stock = Convert.ToInt32(tbt_stock.Text);
        //            _product.ProducerID = cbb_nhasanxuat.SelectedIndex + 1;
        //            _product.CategoryID = cbb_loaihang.SelectedIndex + 1;
        //            _product.DateCreated = DateTime.Now;
        //            _product.LinkImage = linkavatar;
        //            _product.Note = tb_ghichu.Text;
        //            _product.Status = rd_kd.Checked == true ? true : false;

        //            _IQLProductServices.UpdateProduct(p);
        //            //do something
        //        }
        //        else if (dialogResult == DialogResult.No)
        //        {
        //            //do something else
        //        }
        //    }
        //}
    }
}
