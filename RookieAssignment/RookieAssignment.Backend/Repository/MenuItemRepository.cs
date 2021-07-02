using RookieAssignment.Backend.Data.Migrations;
using RookieAssignment.Backend.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieAssignment.Backend.Repository
{
    public class MenuItemRepository : IMenuItemRepository
    {
        public bool CreateMenuItem(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMenuItem(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }

        public ICollection<MenuItem> GetAllMenuItems()
        {
            throw new NotImplementedException();
        }

        public MenuItem GetMenuItem(int menuItemId)
        {
            throw new NotImplementedException();
        }

        public ICollection<MenuItem> GetMenuItemsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public bool IsMenuItemExits(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsMenuItemExits(string name)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateMenuItem(MenuItem menuItem)
        {
            throw new NotImplementedException();
        }
    }
}
