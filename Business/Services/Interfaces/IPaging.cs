using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Services.Interfaces
{
    public interface IPaging
    {
        bool HasMoreItems { get; set; }
        int Page { get; set; }
        int TotalHits { get; set; }
    }
}