﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace Bookstore.Application.DTOs
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }
        public string Author { get; set; }
    }
}
