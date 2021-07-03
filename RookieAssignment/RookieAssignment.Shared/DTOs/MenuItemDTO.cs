using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookieAssignment.Shared.DTOs
{
    public class MenuItemDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public string Image { get; set; }

        public int CategoryId { get; set; }

        public virtual CategoryDTO Category { get; set; }

        public double Price { get; set; }
    }
}
