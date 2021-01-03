using System;
using DAWProject.Controllers.Dtos;
using DAWProject.Models;
using DAWProject.Services.OrderService;
using Microsoft.AspNetCore.Mvc;

namespace DAWProject.Controllers
{
    public class InvoicesController : BaseController<Invoice, InvoiceDto>
    {
        public InvoicesController(IInvoiceService service) : base(service)
        {
        }

        [HttpGet("order/id")]
        public IActionResult GetByOrderId(Guid id)
        {
            var service = (InvoiceService) Service;
            return Ok(service.FindByOrderId(id));
        }

        public override Invoice MapToModel(InvoiceDto dto)
        {
            throw new NotImplementedException();
        }

        public override InvoiceDto MapToDto(Invoice model)
        {
            throw new NotImplementedException();
        }
    }

    public class InvoiceDto : BaseDto
    {
    }
}