using WebMotors.Domain.Commands;

namespace WebMotors.Domain.Interfaces.CommandHandler
{
    public interface ICommandHandler<ICommand> where ICommand : Command
    {
        void handle(ICommand command);
    }
}
