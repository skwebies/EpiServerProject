using BbmUnderlakare.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities
{
    public class StartP : IStartP
    {

        public StartP(/*int id, string name, string info,*/ IEnumerable<AtCity> cityList)
        {
            //Id = id;
            //Info = info;
            //Name = Name;
            CityList = cityList;

        }

        //public int Id
        //{
        //    get;
        //}

        //public string Info
        //{
        //    get;
        //}

        //public string Name
        //{
        //    get;
        //}

        public IEnumerable<AtCity> CityList
        {
            get;
        }
    }
}