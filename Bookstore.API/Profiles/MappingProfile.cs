using AutoMapper;
using Bookstore.Application.DTOs;
using Bookstore.Domain.Models;

namespace Bookstore.API.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BookDto, Book>().ReverseMap();
            CreateMap<CreateUpdateBookDto, Book>().ReverseMap();
        }
    }
}
