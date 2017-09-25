using BbmUnderlakare.Business.Entities;
using BbmUnderlakare.Business.Entities.Interfaces;
using BbmUnderlakare.Models.Pages;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Services.Interfaces
{
    public interface IAtPageService
    {
        IEnumerable<IAtCounty> GetLandsting(int id);
        IEnumerable<IAtCity> GetCity(int id);
        IAtForm GetHospitalForm(int id);
        IEnumerable<IStartP> GetAllLandsting();
        IEnumerable<IAtForm> GetAllHospitalForm();
    }
}