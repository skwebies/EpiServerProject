using BbmUnderlakare.Business.Services.Interfaces;
using BbmUnderlakare.Models.Pages;
using EPiServer;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BbmUnderlakare.Business.Entities.Interfaces;
using BbmUnderlakare.Business.Entities;
using EPiServer.ServiceLocation;

namespace BbmUnderlakare.Business.Services
{
    public class AtPageService : IAtPageService
    {
        private readonly IContentLoader _contentLoader;


        public AtPageService(IContentLoader contentLoader)
        {
            this._contentLoader = contentLoader;
        }

        #region Hämtar SjukhusFormulär med ID

        public IAtForm GetHospitalForm(int id)
        {
            var page = _contentLoader.Get<HospitalFormAt>(new ContentReference(id));
            var parent = _contentLoader.Get<AtCountyPage>(new ContentReference(page.ParentLink.ID));


            return new AtForm(page.ContentLink.ID,
                            page.Name,
                            parent.Name,
                            page.ATblockensLangd,
                            page.ATBlockTermin,
                            page.AntalSokandeBlock,
                            page.Ingangslon,
                            page.LonEfter18Manader,
                            page.STLon,
                            page.Studiepott,
                            page.Personalbostad,
                            page.HyresnivaTreaRok,
                            page.Bostadsmarknad,
                            page.HjalpAttHittaBoende,
                            page.Introduktion,
                            page.Undervisning,
                            page.HandledareHuvudansvar,
                            page.MentorHuvudhandledare,
                            page.Ledarskapsutbildning,
                            page.BetaldATStamma,
                            page.EnsamPaNattjour,
                            page.STTjansterErbjuds,
                            page.MojlighetTillVikariat,
                            page.ObesattaTjanster,
                            page.Upptagningsomrade,
                            page.Ovrigt,
                            page.Kontaktperson);
        }


        #endregion

        #region Hämtar Landsting med respektive sjukhusformulär med ID
        public IEnumerable<IAtCounty> GetLandsting(int id)
        {
            var page = _contentLoader.Get<AtCountyPage>(new ContentReference(id));
            var child = _contentLoader.GetChildren<HospitalFormAt>(new ContentReference(id));

            List<AtForm> listOfProperties = new List<AtForm>();

            foreach (var prop in child)
            {
                var form = new AtForm(prop.ContentLink.ID,
                                    prop.Name,
                                    page.Name,
                                    prop.ATblockensLangd,
                                    prop.ATBlockTermin,
                                    prop.AntalSokandeBlock,
                                    prop.Ingangslon,
                                    prop.LonEfter18Manader,
                                    prop.STLon,
                                    prop.Studiepott,
                                    prop.Personalbostad,
                                    prop.HyresnivaTreaRok,
                                    prop.Bostadsmarknad,
                                    prop.HjalpAttHittaBoende,
                                    prop.Introduktion,
                                    prop.Undervisning,
                                    prop.HandledareHuvudansvar,
                                    prop.MentorHuvudhandledare,
                                    prop.Ledarskapsutbildning,
                                    prop.BetaldATStamma,
                                    prop.EnsamPaNattjour,
                                    prop.STTjansterErbjuds,
                                    prop.MojlighetTillVikariat,
                                    prop.ObesattaTjanster,
                                    prop.Upptagningsomrade,
                                    prop.Ovrigt,
                                    prop.Kontaktperson);

                listOfProperties.Add(form);
            }

            yield return new AtCounty(page.ContentLink.ID, page.Name, page.MainBody, listOfProperties);
        }


        #endregion

        #region Hämtar alla Landsting samt respektive sjukhusformulär med ID
        public IEnumerable<IAtCity> GetCity(int id)
        {
            var page = _contentLoader.Get<AtCityPage>(new ContentReference(id));
            var child = _contentLoader.GetChildren<AtCountyPage>(new ContentReference(id));


            List<AtCounty> listOfCountyProperties = new List<AtCounty>();

            foreach (var prop in child)
            {
                var hospitalForm = _contentLoader.GetChildren<HospitalFormAt>(prop.ContentLink);
                List<AtForm> ListOfFormProperties = new List<AtForm>();

                foreach (var formpage in hospitalForm)
                {
                    var form = new AtForm(formpage.ContentLink.ID,
                                         formpage.Name,
                                         prop.Name,
                                         formpage.ATblockensLangd,
                                         formpage.ATBlockTermin,
                                         formpage.AntalSokandeBlock,
                                         formpage.Ingangslon,
                                         formpage.LonEfter18Manader,
                                         formpage.STLon,
                                         formpage.Studiepott,
                                         formpage.Personalbostad,
                                         formpage.HyresnivaTreaRok,
                                         formpage.Bostadsmarknad,
                                         formpage.HjalpAttHittaBoende,
                                         formpage.Introduktion,
                                         formpage.Undervisning,
                                         formpage.HandledareHuvudansvar,
                                         formpage.MentorHuvudhandledare,
                                         formpage.Ledarskapsutbildning,
                                         formpage.BetaldATStamma,
                                         formpage.EnsamPaNattjour,
                                         formpage.STTjansterErbjuds,
                                         formpage.MojlighetTillVikariat,
                                         formpage.ObesattaTjanster,
                                         formpage.Upptagningsomrade,
                                         formpage.Ovrigt,
                                         formpage.Kontaktperson);

                    ListOfFormProperties.Add(form);

                }

                var pageChild = new AtCounty(prop.ContentLink.ID, prop.Name, prop.MainBody, ListOfFormProperties);

                listOfCountyProperties.Add(pageChild);
            }

            yield return new AtCity(page.ContentLink.ID, page.Name, page.MainBody, listOfCountyProperties);
        }
        #endregion

        #region Hämta alla sjukhusformulär

        public IEnumerable<ISingelAtFormList> GetAllHospitalForms()
        {
            var startPage = ContentReference.StartPage;
            var countyPage = _contentLoader.GetChildren<AtCountyPage>(startPage);

            

            foreach (var countyProp in countyPage)
            {
                List<AtForm> hospitalFormList = new List<AtForm>();
                var hospitalPage = _contentLoader.GetChildren<HospitalFormAt>(countyProp.ContentLink);
                foreach (var hospitalProp in hospitalPage)
                {
                    var formProp = new AtForm(hospitalProp.ContentLink.ID,
                                             hospitalProp.Name,
                                             countyProp.Name,
                                             hospitalProp.ATblockensLangd,
                                             hospitalProp.ATBlockTermin,
                                             hospitalProp.AntalSokandeBlock,
                                             hospitalProp.Ingangslon,
                                             hospitalProp.LonEfter18Manader,
                                             hospitalProp.STLon,
                                             hospitalProp.Studiepott,
                                             hospitalProp.Personalbostad,
                                             hospitalProp.HyresnivaTreaRok,
                                             hospitalProp.Bostadsmarknad,
                                             hospitalProp.HjalpAttHittaBoende,
                                             hospitalProp.Introduktion,
                                             hospitalProp.Undervisning,
                                             hospitalProp.HandledareHuvudansvar,
                                             hospitalProp.MentorHuvudhandledare,
                                             hospitalProp.Ledarskapsutbildning,
                                             hospitalProp.BetaldATStamma,
                                             hospitalProp.EnsamPaNattjour,
                                             hospitalProp.STTjansterErbjuds,
                                             hospitalProp.MojlighetTillVikariat,
                                             hospitalProp.ObesattaTjanster,
                                             hospitalProp.Upptagningsomrade,
                                             hospitalProp.Ovrigt,
                                             hospitalProp.Kontaktperson);
                    hospitalFormList.Add(formProp);
                }

                yield return new SingelAtFormList(hospitalFormList);
            }

        }

        #endregion

        #region Hämtar alla Landsting samt respektive sjukhusformulär

        public IEnumerable<IStartP> GetAllLandsting()
        {

            var startPage = ContentReference.StartPage;
            var cities = _contentLoader.GetChildren<AtCityPage>(startPage);



            List<AtCity> listOfCityProperties = new List<AtCity>();

            foreach (var prop in cities)
            {
                var county = _contentLoader.GetChildren<AtCountyPage>(prop.ContentLink);
                List<AtCounty> listOfCountyProperties = new List<AtCounty>();

                foreach (var propChild in county)
                {
                    var hospitalForm = _contentLoader.GetChildren<HospitalFormAt>(propChild.ContentLink);
                    List<AtForm> ListOfFormProperties = new List<AtForm>();

                    foreach (var formProp in hospitalForm)
                    {
                        var form = new AtForm(formProp.ContentLink.ID,
                                             formProp.Name,
                                             propChild.Name,
                                             formProp.ATblockensLangd,
                                             formProp.ATBlockTermin,
                                             formProp.AntalSokandeBlock,
                                             formProp.Ingangslon,
                                             formProp.LonEfter18Manader,
                                             formProp.STLon,
                                             formProp.Studiepott,
                                             formProp.Personalbostad,
                                             formProp.HyresnivaTreaRok,
                                             formProp.Bostadsmarknad,
                                             formProp.HjalpAttHittaBoende,
                                             formProp.Introduktion,
                                             formProp.Undervisning,
                                             formProp.HandledareHuvudansvar,
                                             formProp.MentorHuvudhandledare,
                                             formProp.Ledarskapsutbildning,
                                             formProp.BetaldATStamma,
                                             formProp.EnsamPaNattjour,
                                             formProp.STTjansterErbjuds,
                                             formProp.MojlighetTillVikariat,
                                             formProp.ObesattaTjanster,
                                             formProp.Upptagningsomrade,
                                             formProp.Ovrigt,
                                             formProp.Kontaktperson);

                        ListOfFormProperties.Add(form);


                    }

                    var pageChild = new AtCounty(propChild.ContentLink.ID, propChild.Name, propChild.MainBody, ListOfFormProperties);

                    listOfCountyProperties.Add(pageChild);

                }

                var pageCity = new AtCity(prop.ContentLink.ID, prop.Name, prop.MainBody, listOfCountyProperties);

                listOfCityProperties.Add(pageCity);

            }

            yield return new StartP(listOfCityProperties);
        }

        #endregion

        #region Hämtar alla Sjukhusformulär

        public IEnumerable<IAtForm> GetAllHospitalForm()
        {
            var startPage = ContentReference.StartPage;
            var cities = _contentLoader.GetChildren<AtCityPage>(startPage);
            foreach (var cityPage in cities)
            {
                var county = _contentLoader.GetChildren<AtCountyPage>(cityPage.ContentLink);

                foreach (var hospitalPage in county)
                {
                    var allFormPages = _contentLoader.GetChildren<HospitalFormAt>(hospitalPage.ContentLink);

                    foreach (var allPages in allFormPages)
                    {
                        yield return new AtForm(allPages.ContentLink.ID,
                                                 allPages.Name,
                                                 hospitalPage.Name,
                                                 allPages.ATblockensLangd,
                                                 allPages.ATBlockTermin,
                                                 allPages.AntalSokandeBlock,
                                                 allPages.Ingangslon,
                                                 allPages.LonEfter18Manader,
                                                 allPages.STLon,
                                                 allPages.Studiepott,
                                                 allPages.Personalbostad,
                                                 allPages.HyresnivaTreaRok,
                                                 allPages.Bostadsmarknad,
                                                 allPages.HjalpAttHittaBoende,
                                                 allPages.Introduktion,
                                                 allPages.Undervisning,
                                                 allPages.HandledareHuvudansvar,
                                                 allPages.MentorHuvudhandledare,
                                                 allPages.Ledarskapsutbildning,
                                                 allPages.BetaldATStamma,
                                                 allPages.EnsamPaNattjour,
                                                 allPages.STTjansterErbjuds,
                                                 allPages.MojlighetTillVikariat,
                                                 allPages.ObesattaTjanster,
                                                 allPages.Upptagningsomrade,
                                                 allPages.Ovrigt,
                                                 allPages.Kontaktperson);
                    }
 
                }
            }
            
        }

        #endregion
    }
}