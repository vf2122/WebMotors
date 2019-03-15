using Ninject;
using WebMotors.Domain.CommandHandlers.Entities;
using WebMotors.Domain.Commands.Entities;
using WebMotors.Domain.Interfaces.CommandHandler;
using WebMotors.Domain.Interfaces.Entities;
using AnuncioWebmotorsRepository = Infra.Data.EFM.Repositories.Entities.AnuncioWebmotorsRepository;

namespace WebMotors.Infra.IoC.Ninject
{
    public static class NinjectBootstrapper
    {
        public static void RegisterService(IKernel kernel)
        {
            kernel.Bind<IAnuncioWebmotorsRepository>().To<AnuncioWebmotorsRepository>();
            kernel.Bind<ICommandHandler<AlterarAnuncioWebMotorsCommand>>().To<AnuncioWebMotorsCommandHandler>();
            kernel.Bind<ICommandHandler<CadastrarAnuncioWebMotorsCommand>>().To<AnuncioWebMotorsCommandHandler>();
            kernel.Bind<ICommandHandler<RemoverAnuncioWebMotorsCommand>>().To<AnuncioWebMotorsCommandHandler>();

        }
    }
}
