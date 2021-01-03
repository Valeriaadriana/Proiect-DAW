using DAWProject.Controllers.Dtos;
using DAWProject.Models;
using DAWProject.Services.OrderService;

namespace DAWProject.Controllers
{
    public class DeliveryTypesController : BaseController<DeliveryType, DeliveryTypeDto>
    {
        public DeliveryTypesController(IDeliveryTypeService service) : base(service)
        {
        }

        public override DeliveryType MapToModel(DeliveryTypeDto dto)
        {
            return new DeliveryType
            {
                Id = dto.Id,
                Name = dto.Name,
                Price = dto.Price
            };
        }

        public override DeliveryTypeDto MapToDto(DeliveryType model)
        {
            return new DeliveryTypeDto
            {
                Id = model.Id,
                Name = model.Name,
                Price = model.Price
            };
        }
    }
}