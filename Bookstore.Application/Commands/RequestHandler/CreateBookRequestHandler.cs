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
    public class CreateBookRequestHandler : IRequestHandler<CreateBookRequest, ApiResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Book> _repository;

        public CreateBookRequestHandler(IMapper mapper, IGenericRepository<Book> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<ApiResponse> Handle(CreateBookRequest request, CancellationToken cancellationToken)
        {
            Book book = _mapper.Map<Book>(request.BookDto);

            FormattableString sql = $"[dbo].[spcCreateBook] @Title = {book.Title}, @Category = {book.Category}, @Price = {book.Price}, @Author  = {book.Author}";

            var response = await _repository.Add(sql);

            if (response > 0)
            {
                return new ApiResponse
                {
                    isSuccess = true,
                    Message = "Book has been added successfully",

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
