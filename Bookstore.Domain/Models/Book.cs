﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Domain.Models
{
    public class Book
    {
        public int BookIdpk { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
    }
}
