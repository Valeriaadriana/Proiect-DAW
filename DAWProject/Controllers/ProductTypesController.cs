using DAWProject.Controllers.Dtos;
using DAWProject.Models;
using DAWProject.Services.ProductService;

namespace DAWProject.Controllers
{
    public class ProductTypesController : BaseController<ProductType, ProductTypeDto>
    {
        public ProductTypesController(IProductTypeService service) : base(service)
        {
        }

        public override ProductType MapToModel(ProductTypeDto dto)
        {
            return new ProductType
            {
                Id = dto.Id,
                Name = dto.Name,
                Perishable = dto.Perishable
            };
        }

        public override ProductTypeDto MapToDto(ProductType model)
        {
            return new ProductTypeDto
            {
                Id = model.Id,
                Name = model.Name,
                Perishable = model.Perishable
            };
        }
    }
}