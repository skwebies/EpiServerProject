using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Exceptions
{
    public class HandledException : Exception
    {
        public bool IncludeInnerExceptionMessage { get; set; } = true;

        public HandledException(string message) : base(message)
        {
        }

        public HandledException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}