using System;
using DAWProject.Models;
using DAWProject.Repositories.GenericRepository;
using DAWProject.Repositories.InvoiceRepository;
using DAWProject.Services.BaseService;

namespace DAWProject.Services.OrderService
{
    public class InvoiceService : BaseService<Invoice>
    {
        public InvoiceService(IGenericRepository<Invoice> repository) : base(repository)
        {
        }

        public Invoice FindByOrderId(Guid id)
        {
            var repository = (InvoiceRepository) _repository;
            return repository.FindByOrderId(id);
        }
    }
}