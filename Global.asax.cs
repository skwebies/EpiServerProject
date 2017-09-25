using BbmUnderlakare.Business.Configurations;
using System;
using System.Web.Http;
using System.Web.Mvc;

namespace BbmUnderlakare
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {



            GlobalConfiguration.Configure(WebApiConfiguration.Register);
            AreaRegistration.RegisterAllAreas();


            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
        }
    }
}