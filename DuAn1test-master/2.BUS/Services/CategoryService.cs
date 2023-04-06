using _1.DAL.Entities;
using _1.DAL.iRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepositories _category;
        private List<Category> _lstCategory;

        public CategoryService()
        {
            _lstCategory = new List<Category>();
            _category = new CategoryRepositories();
        }

        public bool AddCategory(Category category)
        {
            _category.AddCategory(category);
            return true;
        }

        public bool DeleteCategory(Category category)
        {
            _category.DeleteCategory(category);
            return true;
        }

        public List<Category> GetCategoryFromDB()
        {
            _lstCategory = _category.GetCategoryFromDB();
            return _lstCategory;
        }

        public bool UpdateCategory(Category category)
        {
            _category.UpdateCategory(category);
            return true;
        }
    }
}
