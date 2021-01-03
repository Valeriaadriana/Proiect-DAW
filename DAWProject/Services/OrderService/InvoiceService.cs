using System;
using DAWProject.Models;
using DAWProject.Repositories.InvoiceRepository;
using DAWProject.Services.BaseService;

namespace DAWProject.Services.OrderService
{
    public class InvoiceService : BaseService<Invoice>, IInvoiceService
    {
        public InvoiceService(IInvoiceRepository repository) : base(repository)
        {
        }

        public Invoice FindByOrderId(Guid id)
        {
            var repository = (InvoiceRepository) Repository;
            return repository.FindByOrderId(id);
        }
    }
    
    public interface IInvoiceService : IBaseService<Invoice>
    {
        Invoice FindByOrderId(Guid id);
    }
}