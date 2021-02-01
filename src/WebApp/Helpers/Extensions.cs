using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Helpers
{
    public static class Extensions
    {
        public static Dictionary<string, string> ToRouteValues(this RouteValueDictionary data, IQueryCollection query)
        {
            Dictionary<string, string> result = data.ToRouteValues();

            foreach (var item in query)
                result.Add(item.Key, item.Value.ToString());

            return result;
        }

        public static Dictionary<string, string> ToRouteValues(this RouteValueDictionary data)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (var item in data)
            {
                if (item.Key == "culture")
                    continue;

                result.Add(item.Key, item.Value.ToString());
            }

            return result;
        }
    }
}
