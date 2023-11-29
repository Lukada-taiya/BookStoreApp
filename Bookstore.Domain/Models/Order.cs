using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Domain.Models.Common;

namespace Bookstore.Domain.Models
{
    public class Order : BaseModel
    { 
        public string? Customer { get; set; }

        public List<OrderItem>? Books { get; set; }

        [AllowNull]
        public decimal TotalAmount { get; set; }
    }
}
