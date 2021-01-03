using DAWProject.Models;
using DAWProject.Repositories.ProductTypeRepository;
using DAWProject.Services.BaseService;

namespace DAWProject.Services.ProductService
{
    public class ProductTypeService : BaseService<ProductType>, IProductTypeService
    {
        public ProductTypeService(IProductTypeRepository repository) : base(repository)
        {
        }
    }
    
    public interface IProductTypeService : IBaseService<ProductType>
    {
    }
}