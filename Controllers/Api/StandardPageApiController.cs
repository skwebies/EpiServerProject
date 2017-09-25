using BbmUnderlakare.Business.Entities;
using BbmUnderlakare.Business.Services;
using BbmUnderlakare.Business.Services.Interfaces;
using BbmUnderlakare.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BbmUnderlakare.Controllers.Api
{
    [RoutePrefix("api/v1/pages")]
    public class StandardPageApiController : ApiController
    {
        private readonly IAtPageService _atPageService;
        private readonly ILogService _logService;

        public StandardPageApiController(IAtPageService atPageService, ILogService logService)
        {
            _atPageService = atPageService;
            _logService = logService;

        }


        //public StandardPageApiController()
        //{
        //    _atPageService = new AtPageService(ServiceLocator.Current.GetInstance<IContentLoader>());
        //}

        #region Get

        [HttpGet]
        [Route("hospitals/{id:int}")]
        public IHttpActionResult GetHospitalFormPage(int id)
        {
            _logService.Info($"{DateTime.Now} - Getting site page");

                var page = _atPageService.GetHospitalForm(id);
                if (page == null)
                {
                    return Content(HttpStatusCode.NotFound,
                        new ApiResponse("Sidan hittades inte", (int)HttpStatusCode.NotFound));
                }

                return Ok(page);

                //throw new Exception("fel!");
        }

        [HttpGet]
        [Route("region/{id:int}")]
        public IHttpActionResult GetLandstingPage(int id)
        {
            _logService.Info($"{DateTime.Now} - Getting site page");

            var page = _atPageService.GetLandsting(id);
            if (page == null)
            {
                return Content(HttpStatusCode.NotFound,
                    new ApiResponse("Sidan hittades inte", (int)HttpStatusCode.NotFound));
            }

            return Ok(page);

        }



        [HttpGet]
        [Route("city/{id:int}")]
        public IHttpActionResult GetCityPage(int id)
        {
            _logService.Info($"{DateTime.Now} - Getting site page");


            var page = _atPageService.GetCity(id);
            if (page == null)
            {
                return Content(HttpStatusCode.NotFound,
                    new ApiResponse("Sidan hittades inte", (int)HttpStatusCode.NotFound));
            }

            return Ok(page);

        }

        [HttpGet]
        [Route("cities")]
        public IHttpActionResult GetStartPage()
        {
            _logService.Info($"{DateTime.Now} - Getting site page");


            var page = _atPageService.GetAllLandsting();
            if (page == null)
            {
                return Content(HttpStatusCode.NotFound,
                    new ApiResponse("Sidan hittades inte", (int)HttpStatusCode.NotFound));
            }

            return Ok(page);

        }

        [HttpGet]
        [Route("hospitals")]
        public IHttpActionResult GetAllHospitalFormPage()
        {
            _logService.Info($"{DateTime.Now} - Getting site page");

            var page = _atPageService.GetAllHospitalForm();
            if (page == null)
            {
                return Content(HttpStatusCode.NotFound,
                    new ApiResponse("Sidan hittades inte", (int)HttpStatusCode.NotFound));
            }

            return Ok(page);

            //throw new Exception("fel!");
        }

        #endregion
    }
}