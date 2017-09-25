using BbmUnderlakare.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities
{
    public class SingelAtFormList : ISingelAtFormList
    {
        public SingelAtFormList(IEnumerable<AtForm> hospitalList)
        {
            HospitalList = hospitalList;
        }
        public IEnumerable<AtForm> HospitalList { get; }
    }
}