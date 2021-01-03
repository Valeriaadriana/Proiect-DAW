using DAWProject.Models;
using DAWProject.Services.BaseService;

namespace DAWProject.Controllers
{
    public class ProductTypesController : BaseController<ProductType>
    {
        public ProductTypesController(BaseService<ProductType> service) : base(service)
        {
        }
    }
}