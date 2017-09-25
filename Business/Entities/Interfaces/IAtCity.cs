﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Entities.Interfaces
{
    public interface IAtCity
    {
        int Id { get; }
        string Name { get; }

        IEnumerable<AtCounty> CountyList { get; }
    }
}