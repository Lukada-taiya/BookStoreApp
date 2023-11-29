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

        public async Task<ApiResponse> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
        {
            Order Order = _mapper.Map<Order>(request.orderDto);
            FormattableString sql = $"[dbo].[spcCreateOrder] @Customer = {Order.Customer}";
            var response = await _genericRepository.Add(sql);

            if (response > 0)
            {
                sql = $"[dbo].[spcGetOrderId] @Customer = {Order.Customer}";
                var OrderId = await _genericRepository.GetId(sql);
                return new ApiResponse
                {
                    isSuccess = true,
                    Message = "Order has been created successfully",
                    Body = OrderId

                };
            }

            return new ApiResponse
            {
                isSuccess = false,
                Message = "Something went wrong. Try Again"
            };

        }
    }
}
