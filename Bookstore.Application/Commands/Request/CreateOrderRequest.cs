using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Application.DTOs;
using MediatR;

namespace Bookstore.Application.Commands.Request
{
    public class CreateOrderRequest : IRequest<ApiResponse>
    {
        public CreateOrderDto orderDto { get; set; }
    }
}
