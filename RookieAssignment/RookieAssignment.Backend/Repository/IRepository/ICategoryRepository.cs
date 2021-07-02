using RookieAssignment.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieAssignment.Backend.Repository.IRepository
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetAllCategories();
        Category GetCategory(int categoryId);
        bool IsCategoryExits(int id);
        bool IsCategoryExits(string name);
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(Category category);
        bool Save();
    }
}
