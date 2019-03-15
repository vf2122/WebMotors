using System.Collections.Generic;
using System.Linq;
using WebMotors.Domain.Entities;
using WebMotors.Domain.Interfaces;

namespace Infra.Data.EFM.Repositories
{
    public class RepositoryBase<TEntity> : IResitoryBase<TEntity> where TEntity : Entity
    {
        private readonly Context.Context _context;
        public RepositoryBase()
        {
            _context = new Context.Context();
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().FirstOrDefault(x => x.Id == id);
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            var d = GetById(entity.Id);
            d = entity;

            _context.SaveChanges();
        }
    }
}
