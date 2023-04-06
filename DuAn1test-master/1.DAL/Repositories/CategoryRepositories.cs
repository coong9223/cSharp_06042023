using _1.DAL.Context;
using _1.DAL.Entities;
using _1.DAL.iRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class CategoryRepositories : ICategoryRepositories
    {
        private List<Category> _lstCategory;
        private DatabaseContext _context;
        public CategoryRepositories()
        {
            _lstCategory = new List<Category>();
            _context = new DatabaseContext();
        }

        public bool AddCategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteCategory(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
            return true;
        }


        public List<Category> GetCategoryFromDB()
        {
            _lstCategory = _context.Categories.ToList();
            return _lstCategory;
        }


        public bool UpdateCategory(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
            return true;
        }
    }
}
