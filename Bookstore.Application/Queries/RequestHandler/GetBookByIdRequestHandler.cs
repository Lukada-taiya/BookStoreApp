using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bookstore.Application.DTOs;
using Bookstore.Application.Queries.Request;
using Bookstore.Domain.Models;
using MediatR;

namespace Bookstore.Application.Queries.RequestHandler
{
    public class GetBookByIdRequestHandler : IRequestHandler<GetBookByIdRequest,ApiResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Book> _repository;

        public GetBookByIdRequestHandler(IMapper mapper, IGenericRepository<Book> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ApiResponse> Handle(GetBookByIdRequest request, CancellationToken cancellationToken)
        {
            FormattableString sql = $"[dbo].[spcGetBookById] @BookIdpk = {request.BookIdpk}";

            var response = await _repository.GetAsync(sql); ;

            if (response == null)
            {
                return new ApiResponse()
                {
                    isSuccess = false,
                    Message = "Book not found"
                };

            }

            var BookDto = _mapper.Map<BookDto>(response);

            return new ApiResponse()
            {
                isSuccess = true,
                Message = "Book has been retrieved successfully",
                Body = BookDto
            };

        }
    }
}
