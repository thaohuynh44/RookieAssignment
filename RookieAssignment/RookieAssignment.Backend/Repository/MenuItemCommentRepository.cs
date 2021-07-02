using RookieAssignment.Backend.Models;
using RookieAssignment.Backend.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RookieAssignment.Backend.Repository
{
    public class MenuItemCommentRepository : IMenuItemCommentRepository
    {
        public bool CreateMenuItemComment(MenuItemComment comment)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMenuItemComment(MenuItemComment comment)
        {
            throw new NotImplementedException();
        }

        public ICollection<MenuItemComment> GetAllMenuItemComment()
        {
            throw new NotImplementedException();
        }

        public ICollection<MenuItemComment> GetCommentByMenuItem(int menuItemId)
        {
            throw new NotImplementedException();
        }

        public MenuItemComment GetMenuItemComment(int commentId)
        {
            throw new NotImplementedException();
        }

        public bool IsMenuItemCommentExits(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsMenuItemCommentExits(string name)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateMenuItemComment(MenuItemComment comment)
        {
            throw new NotImplementedException();
        }
    }
}
