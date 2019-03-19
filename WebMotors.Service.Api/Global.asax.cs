using Infra.Data.EFM.Repositories.Entities;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebMotors.Domain.CommandHandlers.Entities;
using WebMotors.Domain.Commands.Entities;
using WebMotors.Domain.Interfaces.CommandHandler;
using WebMotors.Domain.Interfaces.Entities;
using SimpleInjector.Integration.WebApi;
using WebMotors.Domain.Commands;
using WebMotors.Domain.Interfaces.Bus;
using WebMotors.Infra.CrossCutting.Bus;
using WebMotors.Application.Interfaces.Entities;
using WebMotors.Application.Services;
using MediatR;
using MediatR.SimpleInjector;

namespace WebMotors.Service.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            container.BuildMediator();


            container.Register<IAnuncioWebmotorsRepository, AnuncioWebmotorsRepository>(Lifestyle.Singleton);
            container.Register<IRequestHandler<AlterarAnuncioWebMotorsCommand, bool>, AnuncioWebMotorsCommandHandler>(Lifestyle.Singleton);
            container.Register<IRequestHandler<CadastrarAnuncioWebMotorsCommand, bool>, AnuncioWebMotorsCommandHandler>(Lifestyle.Singleton);
            container.Register<IRequestHandler<RemoverAnuncioWebMotorsCommand, bool>, AnuncioWebMotorsCommandHandler>(Lifestyle.Singleton);
            container.Register<IMediatorHandler, InMemoryBus>(Lifestyle.Singleton);
            container.Register<IAnuncioWebmotorsAppService, AnuncioWebmotorsAppService>(Lifestyle.Singleton);

            // This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();


            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);

        }
    }
}
