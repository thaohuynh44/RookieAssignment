using RookieAssignment.Backend.Data;
using RookieAssignment.Backend.Models;
using RookieAssignment.Backend.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieAssignment.Backend.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        public bool CreateCategory(Category category)
        {
            _db.Category.Add(category);
            return Save();
        }

        public bool DeleteCategory(Category category)
        {
            _db.Category.Remove(category);
            return Save();
        }

        public ICollection<Category> GetAllCategories()
        {
            return _db.Category.ToList();
        }

        public Category GetCategory(int categoryId)
        {
            return _db.Category.FirstOrDefault(c => c.Id == categoryId);
        }

        public bool IsCategoryExits(int id)
        {
            return _db.Category.Any(c => c.Id == id);
        }

        public bool IsCategoryExits(string name)
        {
            bool value = _db.Category.Any(c => c.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateCategory(Category category)
        {
            _db.Category.Update(category);
            return Save();
        }
    }
}
