using System;
using System.Collections.Generic;
using DAWProject.Models;
using DAWProject.Repositories.GenericRepository;
using DAWProject.Repositories.OrderRepository;
using DAWProject.Services.BaseService;

namespace DAWProject.Services.OrderService
{
    public class OrderService : BaseService<Order>
    {
        public OrderService(IGenericRepository<Order> repository) : base(repository)
        {
        }

        public List<Order> FindByUserId(Guid id)
        {
            var repository = (OrderRepository) _repository;
            return repository.FindByUserId(id);
        }
    }
}