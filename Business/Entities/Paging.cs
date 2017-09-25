using BbmUnderlakare.Business.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities
{
    public class Paging : IPaging
    {
        public bool HasMoreItems { get; set; }
        public int Page { get; set; }
        public int TotalHits { get; set; }
    }
}