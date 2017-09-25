using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities.Interfaces
{
    public interface IAtCounty
    {
        int Id { get; }
        string Name { get; }
        XhtmlString Info { get; }
        IEnumerable<AtForm> HospitalFormProperty { get; }
    }
}