using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieAssignment.Shared.DTOs
{
    public class MenuItemCommentDTO
    {
        public int Id { get; set; }

        public string Comment { get; set; }
        public DateTime PublishedDate { get; set; }
        public int MenuItemId { get; set; }
        //public virtual MenuItemDTO MenuItem { get; set; }
        public int Rating { get; set; }
    }
}
