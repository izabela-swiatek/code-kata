using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CodeKata
{
    public class VowelsRemoving
    {
        public static string Disemvowel(string str)
        {
            Regex regex = new Regex(@"[aeiouAEIOU]");
            string noVoweledString = regex.Replace(str, "");
            return noVoweledString;
        }
    }
}
