using DAWProject.Controllers.Dtos;
using DAWProject.Models;
using DAWProject.Services.ProductService;

namespace DAWProject.Controllers
{
    public class ProductsController : BaseController<Product, ProductDto>
    {
        public ProductsController(IProductService service) : base(service)
        {
        }

        public override Product MapToModel(ProductDto dto)
        {
            return new Product
            {
                Id = dto.Id, Price = dto.Price,
                Name = dto.Name,
                ProductType = new ProductType
                {
                    Id = dto.ProductType.Id, 
                    Name = dto.ProductType.Name,
                    Perishable = dto.ProductType.Perishable
                }
            };
        }

        public override ProductDto MapToDto(Product model)
        {
            return new ProductDto
            {
                Id = model.Id, 
                Name = model.Name,
                Price = model.Price,
                ProductType = new ProductTypeDto
                {
                    Id = model.ProductType.Id, Name = model.ProductType.Name,
                    Perishable = model.ProductType.Perishable
                }
            };
        }
    }
}