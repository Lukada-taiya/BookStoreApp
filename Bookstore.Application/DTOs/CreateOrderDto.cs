using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Domain.Models;

namespace Bookstore.Application.DTOs
{
    public class CreateOrderDto 
    { 
        public string Customer { get; set; }

        public List<OrderItem> Books { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
