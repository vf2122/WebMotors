using System;
using System.Collections.Generic;
using System.Text;

namespace WebMotors.Domain.Interfaces
{
    public interface IResitoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
