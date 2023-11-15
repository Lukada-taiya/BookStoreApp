using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Application.DTOs;
using MediatR;

namespace Bookstore.Application.Commands.Request
{
    public class UpdateBookRequest : IRequest<ApiResponse>
    {
        public int BookIdpk { get; set; }

        public CreateUpdateBookDto BookDto { get; set; }
    }
}
