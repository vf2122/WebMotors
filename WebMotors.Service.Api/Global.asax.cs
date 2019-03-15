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

            container.Register<IAnuncioWebmotorsRepository, AnuncioWebmotorsRepository>(Lifestyle.Singleton);
            container.Register<ICommandHandler<AlterarAnuncioWebMotorsCommand>, AnuncioWebMotorsCommandHandler>(Lifestyle.Singleton);
            container.Register<ICommandHandler<CadastrarAnuncioWebMotorsCommand>, AnuncioWebMotorsCommandHandler>(Lifestyle.Singleton);
            container.Register<ICommandHandler<RemoverAnuncioWebMotorsCommand>, AnuncioWebMotorsCommandHandler>(Lifestyle.Singleton);

            // This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();


            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);

        }
    }
}
