using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class CharDoubled
    {
        public static string DoubleChar(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sb.Append(s[i]);
                }
            }
            return sb.ToString();
        }
    }
}
