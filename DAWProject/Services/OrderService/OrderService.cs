using System;
using System.Collections.Generic;
using DAWProject.Models;
using DAWProject.Repositories.InvoiceRepository;
using DAWProject.Repositories.OrderRepository;
using DAWProject.Services.BaseService;

namespace DAWProject.Services.OrderService
{
    public class OrderService : BaseService<Order>, IOrderService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public OrderService(IOrderRepository repository, IInvoiceRepository invoiceRepository) : base(repository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public Order Create(Order entity)
        {
            var newOrder = Repository.Create(entity);
            Repository.Save();
            _invoiceRepository.Create(new Invoice
            {
                InvoiceNumber = new Random().Next(),
                OrderId = newOrder.Id,
                OrderValue = newOrder.Total
            });
            _invoiceRepository.Save();
            Repository.Save();
            return newOrder;
        }

        public List<Order> FindByUserId(Guid id)
        {
            var repository = (OrderRepository) Repository;
            return repository.FindByUserId(id);
        }
    }
    
    public interface IOrderService : IBaseService<Order>
    {
        List<Order> FindByUserId(Guid id);
    }
}