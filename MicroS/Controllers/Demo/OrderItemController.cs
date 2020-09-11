using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroService.Domain.Demo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroService.API.Controllers.Demo
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderItemController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }


        [HttpGet]
        [Produces("application/json", Type = typeof(List<OrderItem>))]
        public async Task<IActionResult> GetAllItem()
        {
            var items = await _orderRepository.GetAllItem();
            return Ok(items);
        }

        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(OrderItem))]
        public async Task<ActionResult> GetItem(int id)
        {
            var item = await _orderRepository.GetItem(id);
            return Ok(item);
        }
    }
}
