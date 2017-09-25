using BbmUnderlakare.Business.Entities;
using BbmUnderlakare.Business.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace BbmUnderlakare.Handlers
{
    public class ApiExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            var message = context.Exception.Message;
            var handledException = context.Exception as HandledException;

            if (handledException != null && handledException.IncludeInnerExceptionMessage && handledException.InnerException != null)
            {
                message += $". {handledException.InnerException.Message}";
            }

            context.Result =
                new ResponseMessageResult(context.Request.CreateResponse(HttpStatusCode.InternalServerError,
                    new ApiResponse(message, (int)HttpStatusCode.InternalServerError)));
        }

        public override bool ShouldHandle(ExceptionHandlerContext context)
        {
            return true;
        }
    }
}