using System;
using System.Collections.Generic;
using DAWProject.Models.Base;

namespace DAWProject.Services.BaseService
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        List<TEntity> FindAll();
        TEntity FindById(Guid id);
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(Guid id);
    }
}