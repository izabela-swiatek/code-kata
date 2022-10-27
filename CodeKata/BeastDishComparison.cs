using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class BeastDishComparison
    {
        public static bool Feast(string beast, string dish)
        {
            return (beast[0] == dish[0] && beast[beast.Length - 1] == dish[dish.Length - 1]);
        }
    }
}
