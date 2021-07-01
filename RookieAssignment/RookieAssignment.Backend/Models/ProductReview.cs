using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RookieAssignment.Backend.Models
{
    public class ProductReview
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int Rating { get; set; }
        public string Review { get; set; }
    }
}
