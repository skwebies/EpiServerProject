using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Business.Exceptions
{
    public static class ExtensionMethods
    {
        private static readonly JsonSerializerSettings CamelCaseJsonSetting = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
        public static string ToCamelCaseJson<T>(this T o, Formatting formatting = Formatting.None)
        {
            return JsonConvert.SerializeObject(o, formatting, CamelCaseJsonSetting);
        }
    }
}