using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Services.Interfaces
{
    public interface ILogService
    {
        void Debug(string message, params object[] values);
        void Info(string message, params object[] values);
        void Warn(string message, params object[] values);
        void Error(Exception ex, params object[] values);
        void Fatal(string message, params object[] values);
    }
}