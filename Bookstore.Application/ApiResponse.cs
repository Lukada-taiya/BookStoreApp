using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Application
{
    public class ApiResponse
    { 
        public bool isSuccess { get; set; }
        public string Message { get; set; }

        public Object? Body { get; set; }
    }
}
