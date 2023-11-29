using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Domain.Models.Common;

namespace Bookstore.Domain.Models
{
    public class Book : BaseModel
    { 

        public string Title { get; set; }

        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
    }
}
