using BbmUnderlakare.Models.Pages;
using BbmUnderlakare.Models.ViewModels;
using EPiServer.Find;
using EPiServer.Find.Framework;
using EPiServer.Find.UnifiedSearch;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BbmUnderlakare.Controllers.Pages
{
    [TemplateDescriptor(Default = true)]
    public class FindSearchPageController : PageController<SearchPage>
    {

        public ActionResult Index(SearchPage currentPage, string q)
        {

            var hitSpec = new HitSpecification
            {
                HighlightExcerpt = false,
                EncodeTitle = false,
                EncodeExcerpt = false
            };

            var model = new FindSearchPageViewModel(currentPage, q);
            if (String.IsNullOrEmpty(q))
            {
                return View(model);
            }
            var unifiedSearch = SearchClient.Instance.UnifiedSearchFor(q);
            model.Results = unifiedSearch.GetResult();
            return View(model);

        }
    }
}