using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Application.DTOs;
using MediatR;

namespace Bookstore.Application.Commands.Request
{
    public class CreateBookRequest : IRequest<ApiResponse>
    {
        public CreateUpdateBookDto BookDto { get; set; }
    }
}
