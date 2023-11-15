using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Application.DTOs
{
    public class CreateUpdateBookDto
    { 

        public string Title { get; set; }

        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
    }
}
