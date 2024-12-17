using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }
        public int ItemID { get; set; }
        public Items Items { get; set; }
        public string ApplicationUserID { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [Required,MinLength(1)]
        public int Count { get; set; }  
    }
}
