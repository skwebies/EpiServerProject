using BbmUnderlakare.Business.Entities.Interfaces;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities
{
    public class AtCounty : IAtCounty
    {
        public AtCounty(int id, string name, XhtmlString info, IEnumerable<AtForm> hospitalFormProperty)
        {
            Id = id;
            Name = name;
            Info = info;
            HospitalFormProperty = hospitalFormProperty;
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
        public IEnumerable<AtForm> HospitalFormProperty
        {
            get;
        }
    }
}