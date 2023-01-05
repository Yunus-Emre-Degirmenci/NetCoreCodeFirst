using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Order:BaseEntity
    {
        public int AppUserID { get; set; }

        //Relational Property

        public virtual AppUser AppUser { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
