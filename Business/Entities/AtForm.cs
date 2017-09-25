using BbmUnderlakare.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace BbmUnderlakare.Business.Entities
{
    public class AtForm : IAtForm
    {

        public AtForm(int id,
                      string name, 
                      string huvudman, 
                      string aTblockensLangd, 
                      string aTBlockTermin, 
                      string antalSokandeBlock, 
                      string ingangslon, 
                      string lonEfter18Manader, 
                      string sTLon, 
                      string studiepott, 
                      string personalbostad, 
                      string hyresnivaTreaRok, 
                      string bostadsmarknad, 
                      string hjalpAttHittaBoende,
                      string introduktion,
                      string undervisning,
                      string handledareHuvudansvar,
                      string mentorHuvudhandledare,
                      string ledarskapsutbildning,
                      string betaldATStamma,
                      string ensamPaNattjour,
                      string sTTjansterErbjuds,
                      string mojlighetTillVikariat,
                      string obesattaTjanster,
                      string upptagningsomrade,
                      XhtmlString ovrigt,
                      string kontaktperson
                      )
        {
            Id = id;
            Name = name;
            Huvudman = huvudman;
            ATblockensLangd = aTblockensLangd;
            ATBlockTermin = aTBlockTermin;
            AntalSokandeBlock = antalSokandeBlock;
            Ingangslon = ingangslon;
            LonEfter18Manader = lonEfter18Manader;
            STLon = sTLon;
            Studiepott = studiepott;
            Personalbostad = personalbostad;
            HyresnivaTreaRok = hyresnivaTreaRok;
            Bostadsmarknad = bostadsmarknad;
            HjalpAttHittaBoende = hjalpAttHittaBoende;
            Introduktion = introduktion;
            Undervisning = undervisning;
            HandledareHuvudansvar = handledareHuvudansvar;
            MentorHuvudhandledare = mentorHuvudhandledare;
            Ledarskapsutbildning = ledarskapsutbildning;
            BetaldATStamma = betaldATStamma;
            EnsamPaNattjour = ensamPaNattjour;
            STTjansterErbjuds = sTTjansterErbjuds;
            MojlighetTillVikariat = mojlighetTillVikariat;
            ObesattaTjanster = obesattaTjanster;
            Upptagningsomrade = upptagningsomrade;
            Ovrigt = ovrigt;
            Kontaktperson = kontaktperson;

        }

        public int Id
        {
            get;
        }
        public string Name
        {
            get;
        }

        public string Huvudman
        {
            get;
        }

        public string ATblockensLangd
        {
            get;
        }

        public string ATBlockTermin
        {
            get;
        }

        public string AntalSokandeBlock
        {
            get;
        }

        public string Ingangslon
        {
            get;

        }

        public string LonEfter18Manader
        {
            get;
        }

        public string STLon
        {
            get;
        }

        public string Studiepott
        {
            get;
        }

        public string Personalbostad
        {
            get;
        }

        public string HyresnivaTreaRok
        {
            get;
        }

        public string Bostadsmarknad
        {
            get;
        }

        public string HjalpAttHittaBoende
        {
            get;
        }

        public string Introduktion
        {
            get;
        }

        public string Undervisning
        {
            get;
        }

        public string HandledareHuvudansvar
        {
            get;
        }

        public string MentorHuvudhandledare
        {
            get;
        }

        public string Ledarskapsutbildning
        {
            get;
        }

        public string BetaldATStamma
        {
            get;
        }

        public string EnsamPaNattjour
        {
            get;
        }

        public string STTjansterErbjuds
        {
            get;
        }

        public string MojlighetTillVikariat
        {
            get;
        }

        public string ObesattaTjanster
        {
            get;
        }

        public string Upptagningsomrade
        {
            get;
        }

        public XhtmlString Ovrigt
        {
            get;
        }

        public string Kontaktperson
        {
            get;
        }

    }
}