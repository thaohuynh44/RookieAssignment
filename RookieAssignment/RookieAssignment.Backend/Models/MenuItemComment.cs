using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RookieAssignment.Backend.Models
{
    public class MenuItemComment
    {
        [Key]
        public int Id { get; set; }

        public string Comment { get; set; }
        public DateTime PublishedDate { get; set; }
        public int MenuItemId { get; set; }

        [ForeignKey("MenuItemId")]
        public virtual MenuItem MenuItem { get; set; }
        public int Rating { get; set; }

    }
}
