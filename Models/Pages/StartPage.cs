using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace BbmUnderlakare.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "4e9ca47c-37b8-43f3-bf9c-449757612744", Description = "")]
    public class StartPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main Header",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Header { get; set; }


        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString MainBody { get; set; }




        [CultureSpecific]
        [Display(
            Name = "AT-Sjukhus Block",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual ContentArea MainArea { get; set; }
    }
}