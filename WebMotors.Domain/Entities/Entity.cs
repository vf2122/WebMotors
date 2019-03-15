using prmToolkit.NotificationPattern;

namespace WebMotors.Domain.Entities
{
    public abstract class Entity : Notifiable
    {
        public int Id { get; private set; }
    }
}
