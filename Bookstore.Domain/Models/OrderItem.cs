using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Domain.Models.Common;

namespace Bookstore.Domain.Models
{
    public class OrderItem : BaseModel
    {  

        public int BookIdfk { get; set; }
        public virtual Book Book { get; set; }

        public int Quantity { get; set; }
    }
}
