using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BbmUnderlakare.Business.Services.Interfaces
{
    public class Log4NetLogService : ILogService
    {
        private readonly ILog _log;
        public Log4NetLogService(Type type)
        {
            _log = LogManager.GetLogger(type);
        }

        public void Debug(string message, params object[] values)
        {
            _log.Debug(message);
        }

        public void Info(string message, params object[] values)
        {
            _log.Info(message);
        }

        public void Warn(string message, params object[] values)
        {
            _log.Warn(message);
        }

        public void Error(Exception ex, params object[] values)
        {
            _log.Error(string.Format("{0}.{1}{2}{3} Derives from Method '{4}' in file '{5}'.{1}Stacktrace: {7}{1}Inner exception: {6}",
                ex.Message,
                Environment.NewLine,
                GetValues(values),
                Environment.NewLine,
                ex.TargetSite?.Name,
                ex.TargetSite?.DeclaringType != null ? ex.TargetSite.DeclaringType.FullName : string.Empty,
                ex.InnerException,
                ex.StackTrace));
        }

        private string GetValues(object[] values)
        {
            var stringBuilder = new StringBuilder();
            if (values == null || !values.Any()) return stringBuilder.ToString();

            foreach (var value in values)
            {
                stringBuilder.Append(value);
            }

            return stringBuilder.ToString();
        }

        public void Fatal(string message, params object[] values)
        {
            _log.Fatal(message);
        }
    }
}