using WebMotors.Domain.Commands;

namespace WebMotors.Domain.Interfaces.CommandHandler
{
    public interface ICommandHandler<ICommand>
    {
        void handler(ICommand command);
    }
}
