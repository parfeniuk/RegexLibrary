using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexLib
{
    public static class RegexLib
    {
        public static bool IsAddress(this string str)
        {
            if (Regex.IsMatch(str, @"/@/", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
