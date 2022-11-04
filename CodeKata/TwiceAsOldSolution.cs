using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class TwiceAsOldSolution
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            return dadYears - 2 * sonYears > 0 ? dadYears - 2 * sonYears : (dadYears - 2 * sonYears) * (-1);
        }
    }
}
