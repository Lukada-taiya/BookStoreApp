using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Bookstore.Application.Queries.Request
{
    public class GetBookByIdRequest : IRequest<ApiResponse>
    {
        public int BookIdpk { get; set; }
    }
}
