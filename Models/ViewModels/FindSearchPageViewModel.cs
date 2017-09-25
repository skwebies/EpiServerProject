using BbmUnderlakare.Models.Pages;
using EPiServer.Find;
using EPiServer.Find.UnifiedSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Models.ViewModels
{
    public class FindSearchPageViewModel : PageViewModel<SearchPage>
    {

        public FindSearchPageViewModel(SearchPage currentPage, string searchQuery)
            : base(currentPage)
        {
            SearchQuery = searchQuery;

        }
        public string SearchQuery { get; private set; }
        public UnifiedSearchResults Results { get; set; }
    }
}