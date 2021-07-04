using RookieAssignment.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieAssignment.Shared.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<MenuItemDTO> MenuItem { get; set; }
        public IEnumerable<CategoryDTO> Category { get; set; }
    }
}
