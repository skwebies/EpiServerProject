using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace BbmUnderlakare.Business.Entities
{
    public class ApiResponse
    {
        public ApiResponse()
        {

        }
        public ApiResponse(string message, int code)
        {
            Message = message;
            Code = code;
        }

        public static ApiResponse BadRequest(string message = null)
        {
            return new ApiResponse
            {
                Code = (int)HttpStatusCode.BadRequest,
                Message = message
            };
        }

        public string Message { get; set; }
        public int Code { get; set; }
    }
}