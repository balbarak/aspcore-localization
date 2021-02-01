using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebApp.Helpers
{
    public class Language
    {
        public static bool IsEnglish
        {
            get
            {
                return Thread.CurrentThread.CurrentCulture.Name.Contains("en");

            }
        }
    }
}
