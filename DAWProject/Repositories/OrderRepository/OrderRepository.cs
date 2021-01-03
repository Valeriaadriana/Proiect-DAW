using System;
using System.Collections.Generic;
using System.Linq;
using DAWProject.Data;
using DAWProject.Models;
using DAWProject.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace DAWProject.Repositories.OrderRepository
{
    public class OrderRepository: GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(DawAppContext dbContext) : base(dbContext)
        {
        }

        public List<Order> FindByUserId(Guid id)
        {
            return _table.Where(order => order.UserId.Equals(id))
                .Include(order => order.DeliveryType)
                .Include(order => order)
                .ToList();
        }

        public IQueryable<Order> GetAllAsQuerable()
        {
            return _table.Include(order => order.DeliveryType)
                .Include(order => order)
                .Include(order => order.Products)
                .ThenInclude(op => op.Product);
        }
    }
}