using System;
using System.Collections.Generic;
using System.Text;
using WebMotors.Domain.Entities;

namespace WebMotors.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : Entity
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
