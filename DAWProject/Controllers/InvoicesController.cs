using System;
using DAWProject.Models;
using DAWProject.Services.BaseService;
using DAWProject.Services.OrderService;
using Microsoft.AspNetCore.Mvc;

namespace DAWProject.Controllers
{
    public class InvoicesController : BaseController<Invoice>
    {
        public InvoicesController(BaseService<Invoice> service) : base(service)
        {
        }

        [HttpGet("order/id")]
        public IActionResult GetByOrderId(Guid id)
        {
            var service = (InvoiceService) Service;
            return Ok(service.FindByOrderId(id));
        }
    }
}