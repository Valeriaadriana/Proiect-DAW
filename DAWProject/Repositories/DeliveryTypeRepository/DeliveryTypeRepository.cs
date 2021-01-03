using DAWProject.Data;
using DAWProject.Models;
using DAWProject.Repositories.GenericRepository;

namespace DAWProject.Repositories.DeliveryTypeRepository
{
    public class DeliveryTypeRepository: GenericRepository<DeliveryType>, IDeliveryTypeRepository
    {
        public DeliveryTypeRepository(DawAppContext dbContext) : base(dbContext)
        {
        }
    }
}