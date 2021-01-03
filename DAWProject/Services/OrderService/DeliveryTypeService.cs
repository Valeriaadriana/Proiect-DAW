using DAWProject.Models;
using DAWProject.Repositories.DeliveryTypeRepository;
using DAWProject.Services.BaseService;

namespace DAWProject.Services.OrderService
{
    public class DeliveryTypeService : BaseService<DeliveryType>, IDeliveryTypeService
    {
        public DeliveryTypeService(IDeliveryTypeRepository repository) : base(repository)
        {
        }
    }
    
    public interface IDeliveryTypeService : IBaseService<DeliveryType>
    {
        
    }
}