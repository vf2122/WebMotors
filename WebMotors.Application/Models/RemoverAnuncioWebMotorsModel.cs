using WebMotors.Domain.Commands.Entities;

namespace WebMotors.Application.Models
{
    public class RemoverAnuncioWebMotorsModel
    {
        public int Id { get; set; }

        public RemoverAnuncioWebMotorsCommand ToCommand()
        {
            var command = new RemoverAnuncioWebMotorsCommand(this.Id);
            return command;
        }
    }
}