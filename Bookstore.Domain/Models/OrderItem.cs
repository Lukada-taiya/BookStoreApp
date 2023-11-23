using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Domain.Models
{
    public class OrderItem
    {
        public int OrderItemIdpk { get; set; } 

        public int BookIdfk { get; set; }
        public virtual Book Book { get; set; }

        public int Quantity { get; set; }
    }
}
