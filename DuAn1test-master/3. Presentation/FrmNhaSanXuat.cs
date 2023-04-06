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
    public partial class FrmNhaSanXuat : Form
    {
        private IQLProducerServices _qLProducer;
        public Producer p;
        public FrmNhaSanXuat()
        {
            InitializeComponent();
            _qLProducer = new QLProducerServises();
            loadData();
        }
        public void loadData()
        {
            dtg_nsx.Rows.Clear();
            var producer = _qLProducer.GetProducerFromDB();
            foreach (var item in producer)
            {
                dtg_nsx.Rows.Add(item.ID, item.Name);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtg_nsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_nsx.Rows[e.RowIndex];
                p = _qLProducer.GetProducerFromDB().FirstOrDefault(x => x.ID == Convert.ToInt32(r.Cells[0].Value));
                tbt_tenNSX.Text = r.Cells[1].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tbt_tenNSX.Text != "")
            {
                if (_qLProducer.GetProducerFromDB().FirstOrDefault(x => x.Name == tbt_tenNSX.Text) == null)
                {
                    p = new Producer();
                    p.Name = tbt_tenNSX.Text;
                    _qLProducer.AddProducer(p);
                    MessageBox.Show("Thêm thành công");
                    loadData();
                    tbt_tenNSX.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên nhà sản xuất đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên nhà sản xuất");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (p == null)
            {
                MessageBox.Show("Vui lòng chọn nhà sản xuất");
            }
            else
            {
                if (p.Name == tbt_tenNSX.Text || (p.Name != tbt_tenNSX.Text && _qLProducer.GetProducerFromDB().FirstOrDefault(x => x.Name == tbt_tenNSX.Text) == null))
                {
                    p.Name = tbt_tenNSX.Text;
                    _qLProducer.UpdateProducer(p);
                    MessageBox.Show("Cập nhật thành công");
                    loadData();
                    tbt_tenNSX.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên nhà sản xuất đã tồn tại");
                }
            }
        }
    }
}
