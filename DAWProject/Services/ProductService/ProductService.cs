using DAWProject.Models;
using DAWProject.Repositories.GenericRepository;
using DAWProject.Services.BaseService;

namespace DAWProject.Services.ProductService
{
    public class ProductService : BaseService<Product>
    {
        public ProductService(IGenericRepository<Product> repository) : base(repository)
        {
        }
    }
}