using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class NegativeNumber
    {
        public static int MakeNegative(int number)
        {
            return number < 0 ? number : number * -1; ;
        }
    }
}
