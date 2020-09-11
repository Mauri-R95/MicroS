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
    
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }


        [HttpGet]
        [Produces("application/json", Type = typeof(List<Order>))]
        public async Task<IActionResult> GetAllOrder()
        {
            var orders = await _orderRepository.GetAll();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        [Produces("application/json", Type = typeof(Order))]
        public async Task<ActionResult> GetOrder(int id)
        {
            var order = await _orderRepository.Get(id);
            return Ok(order);
        }
    }
}
