using System;
using System.Collections.Generic;
using System.Linq;
using DAWProject.Models.Base;
using DAWProject.Repositories.GenericRepository;

namespace DAWProject.Services.BaseService
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        protected IGenericRepository<TEntity> _repository;

        public BaseService(IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public List<TEntity> FindAll()
        {
            return _repository.GetAllAsQuerable().ToList();
        }

        public TEntity FindById(Guid id)
        {
            return _repository.FindById(id);
        }

        public TEntity Create(TEntity entity)
        {
            var newEntity = _repository.Create(entity);
            _repository.Save();
            return newEntity;
        }

        public TEntity Update(TEntity entity)
        {
            var newEntity = _repository.Update(entity);
            _repository.Save();
            return newEntity;
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
            _repository.Save();
        }

        public void Delete(Guid id)
        {
            var entity = _repository.FindById(id);
            _repository.Delete(entity);
            _repository.Save();
        }
    }
}