using System;
using System.Collections.Generic;
using DAWProject.Models;
using DAWProject.Repositories.GenericRepository;

namespace DAWProject.Repositories.OrderRepository
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        List<Order> FindByUserId(Guid id);
    }
}