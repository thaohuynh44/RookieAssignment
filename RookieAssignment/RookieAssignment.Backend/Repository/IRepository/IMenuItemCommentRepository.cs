using RookieAssignment.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieAssignment.Backend.Repository.IRepository
{
    public interface IMenuItemCommentRepository
    {
        ICollection<MenuItemComment> GetAllMenuItemComment();
        ICollection<MenuItemComment> GetCommentByMenuItem(int menuItemId);
        MenuItemComment GetMenuItemComment(int commentId);
        bool IsMenuItemCommentExits(int id);
        bool IsMenuItemCommentExits(string name);
        bool CreateMenuItemComment(MenuItemComment comment);
        bool UpdateMenuItemComment(MenuItemComment comment);
        bool DeleteMenuItemComment(MenuItemComment comment);
        bool Save();
    }
}
