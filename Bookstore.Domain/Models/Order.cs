using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Domain.Models
{
    public class Order
    {
        public int OrderIdpk { get; set; }
        public string? Customer { get; set; }

        public List<OrderItem>? Books { get; set; }

        [AllowNull]
        public decimal TotalAmount { get; set; }
    }
}
