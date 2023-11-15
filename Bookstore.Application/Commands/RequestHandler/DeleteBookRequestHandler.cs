using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Bookstore.Application.Commands.Request;
using Bookstore.Application.DTOs;
using Bookstore.Domain.Models;
using MediatR;

namespace Bookstore.Application.Commands.RequestHandler
{
    public class DeleteBookRequestHandler : IRequestHandler<DeleteBookRequest, ApiResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Book> _repository;

        public DeleteBookRequestHandler(IMapper mapper, IGenericRepository<Book> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<ApiResponse> Handle(DeleteBookRequest request, CancellationToken cancellationToken)
        {
            

            FormattableString sql = $"[dbo].[spcDeleteBook] @BookIdpk = {request.BookIdpk}";

            var response = await _repository.DeleteAsync(sql);

            if (response > 0)
            {
                return new ApiResponse
                {
                    isSuccess = true,
                    Message = "Book has been deleted successfully",

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
