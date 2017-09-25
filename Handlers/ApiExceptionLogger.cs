using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ExceptionHandling;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EPiServer.ServiceLocation;
using Newtonsoft.Json;
using BbmUnderlakare.Business.Services.Interfaces;
using BbmUnderlakare.Business.Exceptions;

namespace BbmUnderlakare.Handlers
{
    public class ApiExceptionLogger : ExceptionLogger
    {
        public override async Task LogAsync(ExceptionLoggerContext context, CancellationToken cancellationToken)
        {
            var logService = ServiceLocator.Current.GetInstance<ILogService>();

            var requestData = await GetRequestData(context);
            logService.Error(context.Exception, requestData);
        }

        private static async Task<string> GetRequestData(ExceptionLoggerContext context)
        {
            string requestContent = null;

            if (context.Request.Content != null)
            {
                var requestStream = await context.Request.Content.ReadAsStreamAsync();

                if (requestStream.CanSeek)
                {
                    requestStream.Position = 0;
                }

                requestContent = await context.Request.Content.ReadAsStringAsync();
            }

            return new
            {
                Controller = context.ExceptionContext.ControllerContext?.Controller?.GetType().Name,
                Action = context.ExceptionContext.ActionContext?.ActionDescriptor?.ActionName,
                Method = context.Request.Method?.Method,
                RequestUrl = context.Request.RequestUri,
                ReferrerUrl = context.Request.Headers.Referrer,
                UserAgent = context.Request.Headers.UserAgent?.ToString(),
                Host = context.Request.Headers.Host,
                RequestContent = requestContent,
                UserName = context.RequestContext.Principal?.Identity?.Name
            }.ToCamelCaseJson(Formatting.Indented);
        }
    }
}