using DAWProject.Models;
using DAWProject.Services.BaseService;

namespace DAWProject.Controllers
{
    public class DeliveryTypesController : BaseController<DeliveryType>
    {
        public DeliveryTypesController(BaseService<DeliveryType> service) : base(service)
        {
        }
    }
}