using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class MonkeyCountArray
    {
        public static int[] MonkeyCount(int n)
        {
            int[] counted = new int[n];

            for (int i = 0; i < n; i++)
            {
                counted[i] = i + 1;
            }

            return counted;
        }
    }
}
