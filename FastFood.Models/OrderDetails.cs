using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Models
{
    public class OrderDetails
    {
        public int ID { get; set; }
        public int OrderHeaderID {  get; set; }
        public OrderHeader OrderHeader { get; set; }
        public int ItemID { get; set; }
        public Items Items { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price  { get; set; }
    }
}
