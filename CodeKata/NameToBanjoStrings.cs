using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class NameToBanjoStrings
    {
        public static string AreYouPlayingBanjo(string name)
        {
            if (name[0] == 'R' || name[0] == 'r')
            {
                return $"{name} plays banjo";
            }
            else 
            {
                return $"{name} does not play banjo";
            }
        }
    }
}
