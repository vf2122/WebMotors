using Infra.Data.EFM.Repositories.Entities;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repo = new AnuncioWebmotorsRepository();

            var command = new WebMotors.Domain.Commands.Entities.CadastrarAnuncioWebMotorsCommand(
                "Chevrolet",
                "Prisma",
                "basica",
                2010,
                0,
                "");

            var commandHandler = new WebMotors.Domain.CommandHandlers.Entities.AnuncioWebmotorsCommandHandler(_repo);
            commandHandler.handler(command);

            if (commandHandler.IsInvalid())
            {
                foreach (var notif in commandHandler.Notifications)
                {
                    System.Console.WriteLine(notif);
                }
            }
            else
            {
                System.Console.WriteLine("Realizado com sucesso!!");
            }

            System.Console.ReadKey();
        }
    }
}
