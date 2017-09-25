using BbmUnderlakare.Business.Services;
using BbmUnderlakare.Business.Services.Interfaces;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;

namespace BbmUnderlakare.Business.Registries
{
    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
                scan.LookForRegistries();
            });

            ResolverRegistry();
        }

        private void ResolverRegistry()
        {

            {

                ////Services

                For<IAtPageService>().Use<AtPageService>();
                //For<IContainer>().Use<Container>();


                //Logging
                For<ILogService>().AlwaysUnique().Use(s =>
                    s.ParentType == null
                        ? new Log4NetLogService(s.RootType)
                        : new Log4NetLogService(s.ParentType));


            }
        }
    }
}