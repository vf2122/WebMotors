using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebMotors.Application.Interfaces.Entities;
using WebMotors.Application.Services;
using WebMotors.Infra.CrossCutting.Bus;
using MediatR;
using WebMotors.Domain.Interfaces.Bus;
using WebMotors.Domain.Interfaces.Entities;
using Infra.Data.EFM.Repositories.Entities;
using WebMotors.Domain.Commands.Entities;
using WebMotors.Domain.CommandHandlers.Entities;
using SimpleInjector.Integration.Web;
using System.Reflection;
using SimpleInjector.Integration.Web.Mvc;

namespace WebMotors.Apresentation.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            // Integraçao do MediatR com SimleInjector
            MediatR.SimpleInjector.ContainerExtension.BuildMediator(container);

            // Registro das dependências
            container.Register<IAnuncioWebmotorsAppService, AnuncioWebmotorsAppService>(Lifestyle.Singleton);
            container.Register<IMediatorHandler, InMemoryBus>(Lifestyle.Singleton);
            container.Register<IAnuncioWebmotorsRepository, AnuncioWebmotorsRepository>(Lifestyle.Singleton);
            container.Register<IRequestHandler<CadastrarAnuncioWebMotorsCommand, bool>, AnuncioWebMotorsCommandHandler>(Lifestyle.Singleton);
            container.Register<IRequestHandler<AlterarAnuncioWebMotorsCommand, bool>, AnuncioWebMotorsCommandHandler>(Lifestyle.Singleton);
            container.Register<IRequestHandler<RemoverAnuncioWebMotorsCommand, bool>, AnuncioWebMotorsCommandHandler>(Lifestyle.Singleton);

            // This is an extension method from the integration package.
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }
    }
}
