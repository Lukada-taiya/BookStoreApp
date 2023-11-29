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
    public class UpdateBookRequestHandler : IRequestHandler<UpdateBookRequest, ApiResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Book> _repository;

        public UpdateBookRequestHandler(IMapper mapper, IGenericRepository<Book> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<ApiResponse> Handle(UpdateBookRequest request, CancellationToken cancellationToken)
        {
            var book = _mapper.Map<Book>(request.BookDto);
            FormattableString sql = $"[dbo].[spcUpdateBook] @BookIdpk = {request.BookIdpk}, @Title = {book.Title}, @Category = {book.Category}, @Price = {book.Price}, @Author  = {book.Author}";
            var response = await _repository.UpdateAsync(sql);

            if (response > 0)
            {
                sql = $"[dbo].[spcGetBookId] @Title = {book.Title}";
                var BookId = await _repository.GetId(sql);
                return new ApiResponse
                {
                    isSuccess = true,
                    Message = "Book has been updated successfully",
                    Body = BookId
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
