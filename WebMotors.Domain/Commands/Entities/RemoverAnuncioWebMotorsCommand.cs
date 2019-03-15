using prmToolkit.NotificationPattern;

namespace WebMotors.Domain.Commands.Entities
{
    public class RemoverAnuncioWebMotorsCommand : Command
    {
        public int Id { get; set; }

        public RemoverAnuncioWebMotorsCommand(int Id)
        {
            new AddNotifications<RemoverAnuncioWebMotorsCommand>(this)
                .IfFalse(x => Id > 0);
        }
    }
}
