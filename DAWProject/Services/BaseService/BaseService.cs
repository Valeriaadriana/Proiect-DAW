using System;
using System.Collections.Generic;
using System.Linq;
using DAWProject.Models.Base;
using DAWProject.Repositories.GenericRepository;

namespace DAWProject.Services.BaseService
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        protected readonly IGenericRepository<TEntity> Repository;

        protected BaseService(IGenericRepository<TEntity> repository)
        {
            Repository = repository;
        }

        public List<TEntity> FindAll()
        {
            return Repository.GetAllAsQuerable().ToList();
        }

        public TEntity FindById(Guid id)
        {
            return Repository.FindById(id);
        }

        public TEntity Create(TEntity entity)
        {
            var newEntity = Repository.Create(entity);
            Repository.Save();
            return newEntity;
        }

        public TEntity Update(TEntity entity)
        {
            var newEntity = Repository.Update(entity);
            Repository.Save();
            return newEntity;
        }

        public void Delete(TEntity entity)
        {
            Repository.Delete(entity);
            Repository.Save();
        }

        public void Delete(Guid id)
        {
            var entity = Repository.FindById(id);
            Repository.Delete(entity);
            Repository.Save();
        }
    }
}