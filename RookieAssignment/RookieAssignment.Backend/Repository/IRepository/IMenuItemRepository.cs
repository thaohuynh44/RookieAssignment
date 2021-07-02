using RookieAssignment.Backend.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieAssignment.Backend.Repository.IRepository
{
    public interface IMenuItemRepository
    {
        ICollection<MenuItem> GetAllMenuItems();
        ICollection<MenuItem> GetMenuItemsByCategory(int categoryId);
        MenuItem GetMenuItem(int menuItemId);
        bool IsMenuItemExits(int id);
        bool IsMenuItemExits(string name);
        bool CreateMenuItem(MenuItem menuItem);
        bool UpdateMenuItem(MenuItem menuItem);
        bool DeleteMenuItem(MenuItem menuItem);
        bool Save();

    }
}
