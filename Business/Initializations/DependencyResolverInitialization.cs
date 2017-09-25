using System;
using System.Linq;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using StructureMap;
using System.Web.Mvc;
using BbmUnderlakare.Business.Resolvers;
using BbmUnderlakare.Business.Entities.Interfaces;
using BbmUnderlakare.Business.Entities;
using System.Web.Http;
using BbmUnderlakare.Business.Registries;

namespace BbmUnderlakare.Business.Initializations
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        private IContainer _container;

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Container.Configure(ConfigureContainer);

            var resolver = new StructureMapDependencyResolver(context.Container);
            DependencyResolver.SetResolver(resolver);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
            _container = context.Container;
        }

        private void ConfigureContainer(ConfigurationExpression container)
        {
            container.IncludeRegistry<DefaultRegistry>();
            
        }

        public void Initialize(InitializationEngine context)
        {
            //Add initialization logic, this method is called once after CMS has been initialized
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}