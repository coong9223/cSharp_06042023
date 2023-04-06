using _1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.iRepositories
{
    public interface ICategoryRepositories
    {
        bool AddCategory(Category category);
        bool DeleteCategory(Category category);
        bool UpdateCategory(Category category);
        List<Category> GetCategoryFromDB();
    }
}
