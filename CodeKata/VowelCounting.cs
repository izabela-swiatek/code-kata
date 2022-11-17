using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class VowelCounting
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            vowelCount = str.Count(v => vowels.Contains(v));

            return vowelCount;
        }
    }
}
