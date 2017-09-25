using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities.Interfaces
{
    public interface ISingelAtFormList
    {
        IEnumerable<AtForm> HospitalList { get; }
    }
}