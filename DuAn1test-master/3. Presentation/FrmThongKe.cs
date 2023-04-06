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
    public partial class FrmThongKe : Form
    {
        private IQLOderServices _order;
        private IQLOderDetailServices _orderdetail;
        private IQLCustomerServices _customer;
        private IQLProductServices _product;
        public List<Order> _lstOrder;
        public List<OrderDetail> _lstOrderDetail;
        public List<Customer> _lstCustomer;



        public FrmThongKe()
        {
            InitializeComponent();
            _order = new QLOderServices();
            _orderdetail = new QLOderDetailServices();
            _customer = new QLCustomerServices();
            _product = new QLProductServices();
            _lstOrder = _order.GetOderFromDB();
            _lstOrderDetail = new List<OrderDetail>();
            _lstCustomer = new List<Customer>();
            loadDate();
            loadData();

        }

        public void loadDate()
        {
            for (int i = 1; i<13; i++)
            {
                cbb_thang.Items.Add(i);
            }
            var x = Convert.ToInt32(_order.GetOderFromDB().First().dateCreate.ToString("yyyy"));
            var y = Convert.ToInt32(_order.GetOderFromDB().Last().dateCreate.ToString("yyyy"));
            for (int i=x; i <= y; i++)
            {
                cbb_nam.Items.Add(i);
            }
        }
        public void loadData()
        {
            dtgv_show.Rows.Clear();
            var x = (from a in _lstOrder
                     join b in _customer.GetCustomerFromDB() on a.CustomerID equals b.ID
                     join c in _orderdetail.GetOderDetailFromDB() on a.Id equals c.OderID
                     join d in _product.GetProductFromDB() on c.ProducID equals d.Id
                     where b.Phone.Contains(tb_sdt.Text) && d.Name.ToLower().Contains(tb_timkiem.Text.ToLower())
                     select new { a, b, c, d });

            foreach (var i in x)
            {
                dtgv_show.Rows.Add(i.a.Id, i.d.Name, i.c.Quantity, i.c.Price, i.c.Quantity * i.c.Price, i.b.Phone == "0" ? "Khách vãng lai" : i.b.Phone);
            }

            lb_doanhthu.Text = x.Select(x => x.a).Distinct().Sum(x => x.TotalPrice).ToString();
            lb_tonghd.Text = x.GroupBy(x => x.a).Count().ToString();
            lb_chuathanhtoan.Text = x.Select(x => x.a).Distinct().Where(x => x.Status == false).Count().ToString();
            lb_khachhang.Text = x.GroupBy(x => x.b).Count().ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtp_ngay_ValueChanged(object sender, EventArgs e)
        {
            _lstOrder = _order.GetOderFromDB().Where(x => x.dateCreate.ToString("dd-MM-yyyy") == dtp_ngay.Value.ToString("dd-MM-yyyy")).ToList();
            loadData();
        }

        private void cbb_thang_TextChanged(object sender, EventArgs e)
        {
            if(cbb_nam.Text != "")
            {
                _lstOrder = _order.GetOderFromDB().Where(x => (x.dateCreate.Month.ToString() == cbb_thang.Text && x.dateCreate.Year.ToString() == cbb_nam.Text)).ToList();
                loadData();
            }
        }

        private void cbb_nam_TextChanged(object sender, EventArgs e)
        {
            if (cbb_thang.Text != "")
            {
                _lstOrder = _order.GetOderFromDB().Where(x => (x.dateCreate.Month.ToString() == cbb_thang.Text && x.dateCreate.Year.ToString() == cbb_nam.Text)).ToList();
                loadData();
            }
            else
            {
                _lstOrder = _order.GetOderFromDB().Where(x => x.dateCreate.Year.ToString() == cbb_nam.Text).ToList();
                loadData();
            }
        }

        private void tb_sdt_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tb_sdt.Text,out int x) || tb_sdt.Text.Length<=10)
            {
                loadData();
            }
            else
            {
                dtgv_show.Rows.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
