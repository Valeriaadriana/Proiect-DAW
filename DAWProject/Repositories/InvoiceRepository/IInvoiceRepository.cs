using System;
using DAWProject.Models;
using DAWProject.Repositories.GenericRepository;

namespace DAWProject.Repositories.InvoiceRepository
{
    public interface IInvoiceRepository : IGenericRepository<Invoice>
    {
        Invoice FindByOrderId(Guid id);
    }
}