using Bookstore.Application.Commands.Request;
using Bookstore.Application.DTOs;
using Bookstore.Application.Queries.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookStoreController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookStoreController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllBooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            var response = await _mediator.Send(new GetAllBooksRequest());
            return Ok(response);
        }

        [HttpGet]
        [Route("GetBookById")]
        public async Task<IActionResult> GetBookById(int Id)
        {
            var response = await _mediator.Send(new GetBookByIdRequest()
            {
                BookIdpk = Id
            });
            return Ok(response);
        }

        [HttpPost]
        [Route("AddBook")]
        public async Task<IActionResult> AddBook(CreateUpdateBookDto bookDto)
        {
            var response = await _mediator.Send(new CreateBookRequest()
            {
                BookDto = bookDto
            });
            return Ok(response);
        }

        [HttpPut]
        [Route("UpdateBook")]
        public async Task<IActionResult> UpdateBook(int id, CreateUpdateBookDto bookDto)
        {
            var response = await _mediator.Send(new UpdateBookRequest()
            {
                BookIdpk = id,
                BookDto = bookDto
            });
            return Ok(response);
        }

        [HttpDelete]
        [Route("DeleteBook")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var response = await _mediator.Send(new DeleteBookRequest()
            {
                BookIdpk = id
            });
            return Ok(response);
        }

        [HttpGet]
        public async void GetOrderDetails()
        {

        }

        [HttpGet]
        public async void GetTotalOrderAmount()
        {

        }

        [HttpPost]
        public async void AddToOrder()
        {

        }

        [HttpPost]
        public void CreateOrder()
        {

        }

        [HttpDelete]
        public void RemoveFromOrder()
        {

        }
        [HttpDelete]
        public void RemoveOrder()
        {

        }

        [HttpPut]
        public void EditOrderItem()
        {

        }

    }
}
