using DAWProject.Models;
using DAWProject.Services.BaseService;

namespace DAWProject.Controllers
{
    public class ProductsController : BaseController<Product>
    {
        public ProductsController(BaseService<Product> service) : base(service)
        {
        }
    }
}