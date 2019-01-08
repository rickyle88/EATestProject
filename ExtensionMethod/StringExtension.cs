using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class StringExtension
    {
        public static string AddSiteExtension(this string siteName)
        {
            return siteName + ".com";
        }

        public static string add1(string siteName)
        {
            return siteName + ".com";
        }
    }
}
