using DAWProject.Models;
using DAWProject.Repositories.GenericRepository;
using DAWProject.Services.BaseService;

namespace DAWProject.Services.OrderService
{
    public class DeliveryTypeService : BaseService<DeliveryType>
    {
        public DeliveryTypeService(IGenericRepository<DeliveryType> repository) : base(repository)
        {
        }
    }
}