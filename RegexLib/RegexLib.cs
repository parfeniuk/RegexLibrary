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

        public static bool IsFilenameExtentionMatch(this string str, string pathFile, string filenameExtention)
        {
            string pathExtention = System.IO.Path.GetExtension(pathFile);
            var regex = new Regex(@".*/." + filenameExtention + "?$");
            return regex.IsMatch(pathExtention);
        }
    }
}
