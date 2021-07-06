using RookieAssignment.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieAssignment.Shared.ViewModels
{
    public class DetailViewModel
    {
        public MenuItemDTO menuItem { get; set; }
        public IEnumerable<MenuItemCommentDTO> listMenuItemComments { get; set; }
    }
}
