using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Producer.DTOs;
using Producer.Masstransit.SharedModels;

namespace Producer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IPublishEndpoint _publishEndpoint;
        public OrderController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderDto orderDto)
        {
            //await _publishEndpoint.Publish<OrderDto>(new
            //{
            //    Id = 1,
            //    orderDto.ProductName,
            //    orderDto.Quantity,
            //    orderDto.Price
            //});
            await _publishEndpoint.Publish<OrderCreted>(orderDto);
            return Created(nameof(OrderController), orderDto);
        }
    }
}
