using System;
using System.Linq;
using DAWProject.Data;
using DAWProject.Models;
using DAWProject.Repositories.GenericRepository;

namespace DAWProject.Repositories.InvoiceRepository
{
    public class InvoiceRepository : GenericRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(DawAppContext dbContext) : base(dbContext)
        {
        }

        public Invoice FindByOrderId(Guid id)
        {
            return _table.SingleOrDefault(invoice => invoice.OrderId.Equals(id));
        }
    }
}