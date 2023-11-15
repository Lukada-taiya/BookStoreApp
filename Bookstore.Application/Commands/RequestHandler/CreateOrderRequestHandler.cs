﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bookstore.Application.Commands.Request;
using Bookstore.Domain.Models;
using MediatR;

namespace Bookstore.Application.Commands.RequestHandler
{
    public class CreateOrderRequestHandler : IRequestHandler<CreateOrderRequest, ApiResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Order> _genericRepository;

        public CreateOrderRequestHandler(IMapper mapper, IGenericRepository<Order> genericRepository)
        {
            _mapper = mapper;
            _genericRepository = genericRepository;
        }

        public Task<ApiResponse> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
        {
            FormattableString sql = $"";
        }
    }
}