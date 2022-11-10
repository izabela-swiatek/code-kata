using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class IntFromString
    {
        public static int GetAge(string inputString)
        {
            return int.Parse(inputString.Substring(0, 1));
        }

    }
}
