using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Bookstore.Application.Commands.Request
{
    public class DeleteBookRequest : IRequest<ApiResponse>
    {
        public int BookIdpk { get; set; }
    }
}
