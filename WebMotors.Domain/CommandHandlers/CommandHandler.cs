using WebMotors.Domain.Entities;
using WebMotors.Domain.Interfaces;

namespace WebMotors.Domain.CommandHandlers
{
    public abstract class CommandHandler<TEntity> where TEntity : Entity
    {
        protected readonly IRepositoryBase<TEntity> _repository;

        public CommandHandler(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }
    }
}
