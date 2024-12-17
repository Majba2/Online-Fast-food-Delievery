using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }
        [Required]
        public string SubCategoryTitle { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
