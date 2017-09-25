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
<<<<<<< HEAD

    }
=======
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
>>>>>>> b17e5567ba4e4b7b8c7fc3c5756cfae5b459e206
}
