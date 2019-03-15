using Infra.Data.EFM.Repositories.Entities;
using WebMotors.Domain.CommandHandlers.Entities;
using WebMotors.Domain.Commands.Entities;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repo = new AnuncioWebmotorsRepository();
            var coisa = _repo.GetById(1);
            var command = new CadastrarAnuncioWebMotorsCommand(
                "coisa.Marca",
                "coisa.Modelo",
                "coisa.Versao",
                2000,
                1,
                "novo comentario edu"
                );

            var commandHandler = new AnuncioWebMotorsCommandHandler(_repo);
            commandHandler.handle(command);

            //var command = new WebMotors.Domain.Commands.Entities.AlterarAnuncioWebMotorsCommand(
            //    coisa.Id,
            //    coisa.Marca,
            //    coisa.Modelo,
            //    coisa.Versao,
            //    coisa.Ano,
            //    coisa.Quilometragem,
            //    "novo comentario edu"
            //    );

            //var commandHandler = new WebMotors.Domain.CommandHandlers.Entities.AnuncioWebmotorsCommandHandler(_repo);
            //commandHandler.handler(command);

            //if (commandHandler.IsInvalid())
            //{
            //    foreach (var notif in commandHandler.Notifications)
            //    {
            //        System.Console.WriteLine(notif);
            //    }
            //}
            //else
            //{
            //    System.Console.WriteLine("Realizado com sucesso!!");
            //}

            var coisas = _repo.GetAll();

            System.Console.ReadKey();
        }
    }
}
