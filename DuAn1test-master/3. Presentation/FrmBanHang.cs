using _1.DAL.Entities;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModel;
using AForge.Video;
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
    public partial class FrmBanHang : Form
    {
        private IQLProductServices _product;
        private IQLOderDetailServices _orderDetail;
        private IQLOderServices _order;
        private IQLEmployeeServices _employee;
        private IQLCustomerServices _customer;
        public List<OrderDetailVM> _lstOrderDetail;
        public int pID;
        public Customer c;
        public int oID;
        public FrmBanHang()
        {
            InitializeComponent();
            textBox1.Visible = false;
            cbb_listcamera.Visible = false;
            _product = new QLProductServices();
            _orderDetail = new QLOderDetailServices();
            _order = new QLOderServices();
            _employee = new QLEmployeeServices();
            _customer = new QLCustomerServices();
            _lstOrderDetail = new List<OrderDetailVM>();
            c = new Customer();
            oID = -1;

            loadHDcho();
            loadSanPham();

        }
        public void loadSanPham()
        {
            dtg_danhsachSP.Rows.Clear();
            foreach (var item in _product.ShowProduct().Where(x => x.Name.ToLower().Contains(tbt_timkSP.Text.ToLower()) && x.Status == "Kinh doanh" && x.Stock > 0))
            {
                dtg_danhsachSP.Rows.Add(item.Masp, item.Name, item.ProducerName, item.Price, item.Stock);
            }
        }

        public void loadGioHang()
        {
            dtg_giohang.Rows.Clear();
            foreach (var item in _lstOrderDetail)
            {
                dtg_giohang.Rows.Add(item.MaSp, item.ProductName, item.Quantity, item.Price);
            }
            totalCart();
            //dtg_giohang.ColumnCount = 4;
            //dtg_giohang.Columns[0].Name = "Mã Sản Phẩm";
            //dtg_giohang.Columns[1].Name = "Tên Sản Phẩm";
            //dtg_giohang.Columns[2].Name = "Số Lượng";
            //dtg_giohang.Columns[3].Name = "Đơn giá";
            //foreach (var item in _lstOrderDetail)
            //{
            //    dtg_giohang.Rows.Add(item.MaSp, item.ProductName, item.Quantity, item.Price);
            //}
            //totalCart();
        }

        public void addCart(int pID)
        {
            var p = _product.GetProductFromDB().FirstOrDefault(x => x.Id == pID);
            var data = _lstOrderDetail.FirstOrDefault(x => x.ProductID == p.Id);
            if (data == null)
            {
                OrderDetailVM orderDetailVM = new OrderDetailVM()
                {
                    ProductID = p.Id,
                    ProductName = p.Name,
                    Price = p.Price,
                    Quantity = 1,
                    MaSp = p.MaSp
                };
                _lstOrderDetail.Add(orderDetailVM);
            }
            else
            {
                if (data.Quantity == p.Stock)
                {
                    MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                }
                else
                {
                    data.Quantity++;
                }
            }
            loadGioHang();
        }

        private void dtg_giohang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_giohang.Rows[e.RowIndex];
                if (int.TryParse(dtg_giohang.Rows[r.Index].Cells[3].Value.ToString(), out int x))
                {
                    if (dtg_giohang.Rows[r.Index].Cells[3].Value != _lstOrderDetail[r.Index].Quantity.ToString())
                    {
                        if (Convert.ToInt32(dtg_giohang.Rows[r.Index].Cells[3].Value) <= 0)
                        {
                            MessageBox.Show("Nhập sai số lượng");
                            dtg_giohang.Rows[r.Index].Cells[3].Value = _lstOrderDetail[r.Index].Quantity;
                        }
                        else
                        {
                            var p = _product.GetProductFromDB().FirstOrDefault(x => x.Id == _lstOrderDetail[r.Index].ProductID);
                            if (p.Stock < Convert.ToInt32(dtg_giohang.Rows[r.Index].Cells[3].Value))
                            {
                                MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                                dtg_giohang.Rows[r.Index].Cells[3].Value = _lstOrderDetail[r.Index].Quantity;
                            }
                            else
                            {
                                _lstOrderDetail[r.Index].Quantity = Convert.ToInt32(dtg_giohang.Rows[r.Index].Cells[3].Value);
                                totalCart();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai số lượng");
                    dtg_giohang.Rows[r.Index].Cells[3].Value = _lstOrderDetail[r.Index].Quantity;
                }
            }
        }

        private void dtg_danhsachSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_danhsachSP.Rows[e.RowIndex];
                //pID = Convert.ToInt32(r.Cells[0].Value.ToString());
                pID = _product.GetProductFromDB().FirstOrDefault(x => x.MaSp == r.Cells[0].Value.ToString()).Id;
                addCart(pID);
            }
        }

        private void dtg_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_giohang.Rows[e.RowIndex];
                //pID = Convert.ToInt32(r.Cells[0].Value.ToString());
                pID = _product.GetProductFromDB().FirstOrDefault(x => x.MaSp == r.Cells[0].Value.ToString()).Id;
            }
        }

        private void tbt_tienkhachdua_TextChanged(object sender, EventArgs e)
        {
            loadTienThua();
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbt_mahd.Text, out int m) && tbt_mahd.Text != "")
            {
                Order o = _order.GetOderFromDB().FirstOrDefault(x => x.Id == Convert.ToInt32(tbt_mahd.Text) && x.Status == false);
                if (o == null)
                {
                    MessageBox.Show("Đơn hàng không tồn tại hoặc đã thanh toán");
                    lb_tongtien.Text = "0";
                }
                else
                {
                    var customer = _customer.GetCustomerFromDB().FirstOrDefault(x => x.ID == o.CustomerID);
                    int x;
                    if (tbt_giamgia.Text == "" || Convert.ToDecimal(lb_tienthua.Text) < 0 || tbt_tienkhachdua.Text == "" || (!int.TryParse(tbt_giamgia.Text, out x) && tbt_giamgia.Text != "") || !int.TryParse(tbt_tienkhachdua.Text, out int y) || x > customer.Point || x < 0 || Convert.ToDecimal(tbt_giamgia.Text) > Convert.ToDecimal(lb_tongtien.Text) || x>customer.Point)
                    {
                        MessageBox.Show("Vui lòng nhập đúng số tiền");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thanh toán không?", "Thanh toán", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            o.Status = true;
                            _order.UpdateOder(o);
                            if (tbt_tienkhachdua.Text == "0" && Convert.ToDecimal(tbt_giamgia.Text) > o.TotalPrice)
                            {
                                lb_tienthua.Text = "0";
                                customer.Point -= Convert.ToInt32(o.TotalPrice);
                            }
                            else
                            {
                                if (tbt_giamgia.Text != "")
                                {
                                    customer.Point = customer.Point + Convert.ToInt32(o.TotalPrice / 100) - Convert.ToInt32(tbt_giamgia.Text);
                                }
                                else
                                {
                                    customer.Point += Convert.ToInt32(o.TotalPrice / 100);
                                }
                            }
                            _customer.UpdateCustomer(customer);
                            MessageBox.Show("Thanh toán thành công");
                            tbt_giamgia.Text = "";
                            tbt_tienkhachdua.Text = "";
                            lb_tongtien.Text = "0";
                            lb_tienthua.Text = "0";
                            rtb_ghichu.Text = "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
            }
        }

        private void tbt_mahd_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbt_mahd.Text, out int m))
            {
                Order o = _order.GetOderFromDB().FirstOrDefault(x => x.Id == Convert.ToInt32(tbt_mahd.Text) && x.Status == false);
                if (o != null)
                {

                    //var od = _orderDetail.GetOderDetailFromDB().Where(x => x.OderID == o.Id).ToList();
                    //dtg_giohang.Rows.Clear();
                    //foreach (var item in od)
                    //{
                    //    dtg_giohang.Rows.Add(item.ProducID, item.OderID, item.Price, item.Quantity);
                    //}
                    //totalCart();

                    lb_tongtien.Text = o.TotalPrice.ToString();
                    var customer = _customer.GetCustomerFromDB().FirstOrDefault(x => x.ID == o.CustomerID);
                    lb_giamgia.Text = $"(Tối đa : {customer.Point})";
                }
                else
                {
                    lb_tongtien.Text = "0";
                    lb_giamgia.Text = "(Tối đa : 0)";
                }
            }
        }

        private void tbt_giamgia_TextChanged(object sender, EventArgs e)
        {
            loadTienThua();
        }

        public void loadTienThua()
        {
            if (!(tbt_tienkhachdua.Text == "" && tbt_giamgia.Text == ""))
            {
                if (tbt_giamgia.Text == "")
                {
                    if (decimal.TryParse(tbt_tienkhachdua.Text, out decimal x))
                    {
                        lb_tienthua.Text = (Convert.ToDecimal(tbt_tienkhachdua.Text) - Convert.ToDecimal(lb_tongtien.Text)).ToString();
                    }
                }
                else
                {
                    if (decimal.TryParse(tbt_tienkhachdua.Text, out decimal x) && decimal.TryParse(tbt_giamgia.Text, out decimal y))
                    {
                        lb_tienthua.Text = (Convert.ToDecimal(tbt_tienkhachdua.Text) - Convert.ToDecimal(lb_tongtien.Text) + Convert.ToDecimal(tbt_giamgia.Text)).ToString();
                    }
                }
            }
        }

        private void btn_XoaSP_Click_1(object sender, EventArgs e)
        {
            if (_lstOrderDetail.Any())
            {
                var item = _lstOrderDetail.FirstOrDefault(x => x.ProductID == pID);
                _lstOrderDetail.Remove(item);
                loadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void btn_xoaGioHang_Click_1(object sender, EventArgs e)
        {
            if (_lstOrderDetail.Any())
            {
                _lstOrderDetail = new List<OrderDetailVM>();
                loadGioHang();
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_lstOrderDetail.Any())
            {
                decimal total = 0;
                foreach (var item in _lstOrderDetail)
                {
                    total += item.Price * item.Quantity;
                }
                int eID = _employee.GetEmployeeFromDB().FirstOrDefault(x => x.Email == Properties.Settings.Default.TKdaLogin).ID;
                c = _customer.GetCustomerFromDB().FirstOrDefault(x => x.Phone == tb_sdt.Text);
                if (c != null)
                {
                    Order o = new Order()
                    {
                        dateCreate = DateTime.Now,
                        EmployeeID = eID,
                        CustomerID = c.ID,
                        TotalPrice = total,
                        Status = false,
                        Note = ""
                    };
                    _order.AddOder(o);
                    foreach (var item in _lstOrderDetail)
                    {
                        OrderDetail od = new OrderDetail()
                        {
                            OderID = o.Id,
                            ProducID = item.ProductID,
                            Price = item.Price,
                            Quantity = item.Quantity
                        };
                        _orderDetail.AddOderDetail(od);
                        var p = _product.GetProductFromDB().FirstOrDefault(x => x.Id == item.ProductID);
                        p.Stock -= item.Quantity;
                        _product.UpdateProduct(p);
                    }

                    tbt_mahd.Text = o.Id.ToString();
                    lb_tongtien.Text = o.TotalPrice.ToString();
                    tb_sdt.Text = "";
                    lb_totalcart.Text = "";
                    MessageBox.Show($"Tạo hóa đơn thành công. ID: {o.Id}");
                    loadSanPham();
                    loadHDcho();
                    _lstOrderDetail = new List<OrderDetailVM>();
                    dtg_giohang.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập khách hàng");
                }
            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tb_sdt.Text, out int x))
            {
                c = _customer.GetCustomerFromDB().FirstOrDefault(x => x.Phone == tb_sdt.Text);
                if (c != null)
                {
                    lb_tenkh.Text = c.Name;
                    lb_point.Text = c.Point.ToString();
                }
                else
                {
                    lb_tenkh.Text = "";
                    lb_point.Text = "";
                }
            }
            else
            {
                lb_tenkh.Text = "";
                lb_point.Text = "";
            }
        }

        public void totalCart()
        {
            if (_lstOrderDetail != null)
            {
                int total = 0;
                foreach (var item in _lstOrderDetail)
                {
                    total += Convert.ToInt32(item.Price) * item.Quantity;
                }
                lb_totalcart.Text = total.ToString();
            }
            else
            {
                lb_totalcart.Text = "";
            }
        }

        private void dgv_hdcho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgv_hdcho.Rows[e.RowIndex];
                oID = Convert.ToInt32(r.Cells[0].Value.ToString());
                tbt_mahd.Text = oID.ToString();

                var od = _orderDetail.GetOderDetailFromDB().Where(x => x.OderID == oID);
                var cid = _order.GetOderFromDB().FirstOrDefault(x => x.Id == oID).CustomerID;
                var c = _customer.GetCustomerFromDB().FirstOrDefault(x => x.ID == cid);
                tb_sdt.Text = c.Phone;

                _lstOrderDetail = new List<OrderDetailVM>();
                foreach (var item in od)
                {
                    var p = _product.GetProductFromDB().FirstOrDefault(x => x.Id == item.ProducID);

                    OrderDetailVM orderDetailVM = new OrderDetailVM()
                    {
                        ProductID = p.Id,
                        MaSp = p.MaSp,
                        ProductName = p.Name,
                        Price = p.Price,
                        Quantity = od.FirstOrDefault(x => x.ProducID == p.Id).Quantity
                    };
                    _lstOrderDetail.Add(orderDetailVM);

                    loadGioHang();
                }
            }
        }

        public void loadHDcho()
        {
            //dgv_hdcho.Rows.Clear();
            //var hdCho = _order.GetOderFromDB().Where(x => x.Status == false);
            //foreach (var item in hdCho)
            //{
            //    dgv_hdcho.Rows.Add(item.Id.ToString());
            //}

            dgv_hdcho.Rows.Clear();
            var hdCho = (from a in _order.GetOderFromDB()
                         join b in _customer.GetCustomerFromDB() on a.CustomerID equals b.ID
                         where a.Status == false
                         select new { a, b });
            foreach (var item in hdCho)
            {
                dgv_hdcho.Rows.Add(item.a.Id, item.b.Name);
            }

        }

        private void btn_capNhapHĐ_Click(object sender, EventArgs e)
        {
            if (oID != -1)
            {
                if (_lstOrderDetail.Any())
                {
                    int total = 0;
                    c = _customer.GetCustomerFromDB().FirstOrDefault(x => x.Phone == tb_sdt.Text);
                    if (c != null)
                    {
                        var order = _order.GetOderFromDB().FirstOrDefault(x => x.Id == oID);
                        var odd = _orderDetail.GetOderDetailFromDB().Where(x => x.OderID == oID);
                        foreach (var item in odd)
                        {
                            _orderDetail.DeleteOderDetail(item);
                        }


                        foreach (var item in _lstOrderDetail)
                        {
                            OrderDetail od = new OrderDetail()
                            {
                                OderID = oID,
                                ProducID = item.ProductID,
                                Price = item.Price,
                                Quantity = item.Quantity
                            };
                            total += Convert.ToInt32(item.Price * item.Quantity);
                            _orderDetail.AddOderDetail(od);
                            var p = _product.GetProductFromDB().FirstOrDefault(x => x.Id == item.ProductID);
                            p.Stock -= item.Quantity;
                            _product.UpdateProduct(p);
                        }

                        int eID = _employee.GetEmployeeFromDB().FirstOrDefault(x => x.Email == Properties.Settings.Default.TKdaLogin).ID;
                        order.dateCreate = DateTime.Now;
                        order.EmployeeID = eID;
                        order.CustomerID = c.ID;
                        order.TotalPrice = total;
                        _order.UpdateOder(order);

                        tbt_mahd.Text = oID.ToString();
                        lb_tongtien.Text = total.ToString();
                        tb_sdt.Text = "";
                        lb_totalcart.Text = "";
                        MessageBox.Show($"Cập nhật hóa đơn thành công. ID: {oID}");
                        oID = -1;
                        loadSanPham();
                        loadHDcho();
                        dtg_giohang.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập khách hàng");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn chưa thanh toán");
            }
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
            {
                cbb_listcamera.Items.Add(device.Name);
            }
            cbb_listcamera.SelectedIndex = 0;
            //videoCaptureDevice = new VideoCaptureDevice();
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbb_listcamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;

            videoCaptureDevice.Start();
            timer1.Start();



        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            //BarcodeReader reader = new BarcodeReader();
            //var result = reader.Decode(bitmap);
            //if (result != null)
            //{
            //    textBox1.Invoke(new MethodInvoker(delegate { textBox1.Text = result.ToString(); }));

            //}
            pictureBox1.Image = bitmap;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    textBox1.Text = result.ToString();
                    //timer1.Stop();
                    if (videoCaptureDevice.IsRunning)
                    {
                        //videoCaptureDevice.Stop();
                    }

                }
                /*pictureBox1.Image = bitmap*/;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            var p = _product.GetProductFromDB().FirstOrDefault(x => x.MaSp == textBox1.Text);
            if (p == null)
            {
                //MessageBox.Show("Không tìm thấy sản phẩm", "Cảnh báo");
            }
            else
            {
                var data = _lstOrderDetail.FirstOrDefault(x => x.ProductID == p.Id);
                if (data == null)
                {
                    OrderDetailVM orderDetailVM = new OrderDetailVM()
                    {
                        ProductID = p.Id,
                        ProductName = p.Name,
                        Price = p.Price,
                        Quantity = 1,
                        MaSp = p.MaSp
                    };
                    _lstOrderDetail.Add(orderDetailVM);


                }
                else
                {
                    if (data.Quantity == p.Stock)
                    {
                        MessageBox.Show("Sản phẩm trong giỏ hàng đã vượt quá số lượng cho phép");
                    }
                    else
                    {
                        data.Quantity++;
                    }
                }


            }
            loadGioHang();
            textBox1.Text = "";
        }

        private void FrmBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void FrmBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void tbt_timkSP_TextChanged(object sender, EventArgs e)
        {
            loadSanPham();
        }
    }
}
