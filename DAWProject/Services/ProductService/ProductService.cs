using DAWProject.Models;
using DAWProject.Repositories.ProductRepository;
using DAWProject.Services.BaseService;

namespace DAWProject.Services.ProductService
{
    public class ProductService : BaseService<Product>, IProductService
    {
        public ProductService(IProductRepository repository) : base(repository)
        {
        }

        public Product Create(Product entity)
        {
            entity.ProductTypeId = entity.ProductType.Id;
            entity.ProductType = null;
            var newEntity = Repository.Create(entity);
            Repository.Save();
            return newEntity;
        }
    }

    public interface IProductService : IBaseService<Product>
    {
    }
}