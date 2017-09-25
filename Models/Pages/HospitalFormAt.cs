using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace BbmUnderlakare.Models.Pages
{
    [ContentType(DisplayName = "HospitalFormAt", GUID = "c28416e0-4e8d-4982-bf25-9a91d9946852", Description = "")]
    public class HospitalFormAt : PageData
    {
        [CultureSpecific]
        [Display(
           Name = "Huvudman:",
           Description = "Name field's description",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        public virtual string Huvudman { get; set; }

        [CultureSpecific]
        [Display(
            Name = "AT-blockens längd:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string ATblockensLangd { get; set; }

        [CultureSpecific]
        [Display(
            Name = "AT-block/termin:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual string ATBlockTermin { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Antal sökande/block:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual string AntalSokandeBlock { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Ingångslön:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual string Ingangslon { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Lön efter 18 månader:",
           Description = "Name field's description",
           GroupName = SystemTabNames.Content,
           Order = 6)]
        public virtual string LonEfter18Manader { get; set; }

        [CultureSpecific]
        [Display(
            Name = "ST-lön:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 7)]
        public virtual string STLon { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Studiepott:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 8)]
        public virtual string Studiepott { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Personalbostad:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 9)]
        public virtual string Personalbostad { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Hyresnivå trea rok:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string HyresnivaTreaRok { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Bostadsmarknad:",
           Description = "Name field's description",
           GroupName = SystemTabNames.Content,
           Order = 11)]
        public virtual string Bostadsmarknad { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Hjälp att hitta boende:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 12)]
        public virtual string HjalpAttHittaBoende { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Introduktion:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 13)]
        public virtual string Introduktion { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Undervisning:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 14)]
        public virtual string Undervisning { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Självstudier:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 15)]
        public virtual string Sjalvstudier { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Handledare/huvudansvar:",
           Description = "Name field's description",
           GroupName = SystemTabNames.Content,
           Order = 16)]
        public virtual string HandledareHuvudansvar { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Mentor/huvudhandledare:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 17)]
        public virtual string MentorHuvudhandledare { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Ledarskapsutbildning:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 18)]
        public virtual string Ledarskapsutbildning { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Betald AT-stämma:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 19)]
        public virtual string BetaldATStamma { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Ensam på nattjour:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string EnsamPaNattjour { get; set; }

        [CultureSpecific]
        [Display(
            Name = "ST-tjänster erbjuds:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 21)]
        public virtual string STTjansterErbjuds { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Möjlighet till vikariat:",
           Description = "Name field's description",
           GroupName = SystemTabNames.Content,
           Order = 22)]
        public virtual string MojlighetTillVikariat { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Obesatta tjänster:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 23)]
        public virtual string ObesattaTjanster { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Antal läkare:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 24)]
        public virtual string AntalLakare { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Upptagningsområde:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 25)]
        public virtual string Upptagningsomrade { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Övrigt:",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 26)]
        public virtual XhtmlString Ovrigt { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Kontaktperson:",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 27)]
        public virtual string Kontaktperson { get; set; }
    }
}