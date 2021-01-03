using DAWProject.Models;
using DAWProject.Repositories.GenericRepository;
using DAWProject.Services.BaseService;

namespace DAWProject.Services.ProductService
{
    public class ProductTypeService : BaseService<ProductType>
    {
        public ProductTypeService(IGenericRepository<ProductType> repository) : base(repository)
        {
        }
    }
}