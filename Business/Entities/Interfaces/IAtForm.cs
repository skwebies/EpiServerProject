using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities.Interfaces
{
    public interface IAtForm
    {
        int Id { get; }
        string Name { get; }
        string Huvudman { get; }
        string ATblockensLangd { get; }
        string ATBlockTermin { get; }
        string AntalSokandeBlock { get; }
        string Ingangslon { get; }
        string LonEfter18Manader { get; }
        string STLon { get; }
        string Studiepott { get; }
        string Personalbostad { get; }
        string HyresnivaTreaRok { get; }
        string Bostadsmarknad { get; }
        string HjalpAttHittaBoende { get; }
        string Introduktion { get; }
        string Undervisning { get; }
        string HandledareHuvudansvar { get; }
        string MentorHuvudhandledare { get; }
        string Ledarskapsutbildning { get; }
        string BetaldATStamma { get; }
        string EnsamPaNattjour { get; }
        string STTjansterErbjuds { get; }
        string MojlighetTillVikariat { get; }
        string ObesattaTjanster { get; }
        string Upptagningsomrade { get; }
        XhtmlString Ovrigt { get; }
        string Kontaktperson { get; }

    }
}