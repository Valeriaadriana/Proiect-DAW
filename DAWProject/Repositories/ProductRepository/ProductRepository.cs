using System.Linq;
using DAWProject.Data;
using DAWProject.Models;
using DAWProject.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace DAWProject.Repositories.ProductRepository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DawAppContext dbContext) : base(dbContext)
        {
        }

        public IQueryable<Product> GetAllAsQuerable()
        {
            return _table.Include(product => product.ProductType);
        }
    }
}