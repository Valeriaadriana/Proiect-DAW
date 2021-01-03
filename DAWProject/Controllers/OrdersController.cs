using System;
using DAWProject.Models;
using DAWProject.Services.BaseService;
using DAWProject.Services.OrderService;
using Microsoft.AspNetCore.Mvc;

namespace DAWProject.Controllers
{
    public class OrdersController : BaseController<Order>
    {
        public OrdersController(BaseService<Order> service) : base(service)
        {
        }

        [HttpGet("id")]
        public IActionResult GetByUserId(Guid id)
        {
            var service = (OrderService) Service;
            return Ok(service.FindByUserId(id));
        }
    }
}