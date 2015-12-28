using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public static class StringHelper
    {
        public static string ValueOfAppSettings(this string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
