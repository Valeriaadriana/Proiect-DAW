using DAWProject.Data;
using DAWProject.Models;
using DAWProject.Repositories.GenericRepository;

namespace DAWProject.Repositories.ProductTypeRepository
{
    public class ProductTypeRepository : GenericRepository<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(DawAppContext dbContext) : base(dbContext)
        {
        }
    }
}