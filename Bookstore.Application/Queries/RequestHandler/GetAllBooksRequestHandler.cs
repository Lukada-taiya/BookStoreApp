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
    public class GetAllBooksRequestHandler : IRequestHandler<GetAllBooksRequest, ApiResponse>
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Book> _repository;

        public GetAllBooksRequestHandler(IMapper mapper, IGenericRepository<Book> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<ApiResponse> Handle(GetAllBooksRequest request, CancellationToken cancellationToken)
        {
            FormattableString sql = $"[dbo].[spcGetAllBooks]";

            var response = await _repository.GetAllAsync(sql); ;

            IEnumerable<BookDto> BookDtos = _mapper.Map<IEnumerable<BookDto>>(response);

            if (BookDtos.Count<BookDto>() == 0)
            {
                return new ApiResponse()
                {
                    isSuccess = false,
                    Message = "Books not found"
                };

            }


            return new ApiResponse() {
                isSuccess = true,
                Message = "Books has been retrieved successfully",
                Body = BookDtos
            };
            
        }
        
     }
   }

