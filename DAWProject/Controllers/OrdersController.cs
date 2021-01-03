using System;
using System.Linq;
using DAWProject.Controllers.Dtos;
using DAWProject.Models;
using DAWProject.Services.OrderService;
using Microsoft.AspNetCore.Mvc;

namespace DAWProject.Controllers
{
    public class OrdersController : BaseController<Order, OrderDto>
    {
        public OrdersController(IOrderService service) : base(service)
        {
        }


        [HttpGet("id")]
        public IActionResult GetByUserId(Guid id)
        {
            var service = (OrderService) Service;
            return Ok(service.FindByUserId(id));
        }

        public override Order MapToModel(OrderDto dto)
        {
            return new Order
            {
                Id = dto.Id, Total = dto.Total, DeliveryDate = dto.DeliveryDate,
                DeliveryType = new DeliveryType
                {
                    Name = dto.DeliveryType.Name,
                    Price = dto.DeliveryType.Price
                },
                Products = dto.Products.Select(product => new OrderProduct
                {
                    ProductId = product.Id,
                    // Product = new Product
                    // {
                    //     Id = product.Id,
                    //     Price = product.Price,
                    //     ProductType = new ProductType
                    //     {
                    //         Id = product.ProductType.Id,
                    //         Name = product.ProductType.Name,
                    //         Perishable = product.ProductType.Perishable
                    //     }
                    // },
                    OrderId = dto.Id
                }).ToList()
            };
        }

        public override OrderDto MapToDto(Order model)
        {
            return new OrderDto
            {
                Id = model.Id, Total = model.Total, DeliveryDate = model.DeliveryDate,
                DeliveryType = new DeliveryTypeDto
                {
                    Name = model.DeliveryType.Name,
                    Price = model.DeliveryType.Price
                },
                Products = model.Products.Select(product => new ProductDto
                {
                    Id = product.ProductId,
                    Price = product.Product.Price,
                    ProductType = new ProductTypeDto
                    {
                        Id = product.Product.ProductType.Id,
                        Name = product.Product.ProductType.Name,
                        Perishable = product.Product.ProductType.Perishable
                    }
                }).ToList()
            };
        }
    }
}