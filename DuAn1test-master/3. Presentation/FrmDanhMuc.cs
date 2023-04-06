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
    public partial class FrmDanhMuc : Form
    {
        private ICategoryService _categoryService;
        public Category c;
        public FrmDanhMuc()
        {
            InitializeComponent();
            _categoryService = new CategoryService();
            loadData();
        }

        public void loadData()
        {
            dtg_DM.Rows.Clear();
            var producer = _categoryService.GetCategoryFromDB();
            foreach (var item in producer)
            {
                dtg_DM.Rows.Add(item.ID, item.Name);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtg_DM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_DM.Rows[e.RowIndex];
                c = _categoryService.GetCategoryFromDB().FirstOrDefault(x => x.ID == Convert.ToInt32(r.Cells[0].Value));
                tbt_tenDM.Text = r.Cells[1].Value.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tbt_tenDM.Text != "")
            {
                if (_categoryService.GetCategoryFromDB().FirstOrDefault(x => x.Name == tbt_tenDM.Text) == null)
                {
                    c = new Category();
                    c.Name = tbt_tenDM.Text;
                    _categoryService.AddCategory(c);
                    MessageBox.Show("Thêm thành công");
                    loadData();
                    tbt_tenDM.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên danh mục đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên danh mục");
            }
        }


        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (c == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục");
            }
            else
            {
                if (c.Name == tbt_tenDM.Text || (c.Name != tbt_tenDM.Text && _categoryService.GetCategoryFromDB().FirstOrDefault(x => x.Name == tbt_tenDM.Text)==null))
                {
                    c.Name = tbt_tenDM.Text;
                    _categoryService.UpdateCategory(c);
                    MessageBox.Show("Cập nhật thành công");
                    loadData();
                    tbt_tenDM.Text = "";
                }
                else
                {
                    MessageBox.Show("Tên danh mục đã tồn tại");
                }
            }
        }
    }
}

