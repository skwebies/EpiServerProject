using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace BbmUnderlakare.Models.Pages
{
    [ContentType(DisplayName = "AtCountyPage", GUID = "d77b8be2-b9f0-4779-b6a3-62099db30832", Description = "")]
    public class AtCountyPage : PageData
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