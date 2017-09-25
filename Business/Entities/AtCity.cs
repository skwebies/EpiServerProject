using BbmUnderlakare.Business.Entities.Interfaces;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities
{
    public class AtCity : IAtCity
    {
        public AtCity(int id, string name, XhtmlString info, IEnumerable<AtCounty> countyList)
        {
            Id = id;
            Name = name;
            Info = info;
            CountyList = countyList;

        }



        public int Id
        {
            get;
        }

        public string Name
        {
            get;
        }
        public XhtmlString Info
        {
            get;
        }

        public IEnumerable<AtCounty> CountyList
        {
            get;
        }
    }
}