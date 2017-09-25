using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities.Interfaces
{
    public interface IStartP
    {
        //int Id { get; }
        //string Name { get; }
        //string Info { get; }

        IEnumerable<AtCity> CityList { get; }

    }
}