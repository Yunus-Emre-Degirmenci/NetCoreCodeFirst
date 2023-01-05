using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class OrderDetail:BaseEntity
    {
        public short Quantity { get; set; }
        public decimal? TotalPrice { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }


        //Relation Property

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
