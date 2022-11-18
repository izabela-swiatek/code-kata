using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class NumberDigitsSquaring
    {
        public static int SquareDigits(int n)
        {
            string nStringed = n.ToString();
            int[] nDigitized = new int[nStringed.Length];

            for (var i = 0; i < nStringed.Length; i++)
            {
                char currentChar = nStringed[i];
                double currentNumber = char.GetNumericValue(currentChar);
                nDigitized[i] = (int)Math.Pow(currentNumber, 2);
            }

            var stringResult = string.Join(string.Empty, nDigitized);

            var intResult = int.Parse(stringResult);

            return intResult;
        }
    }
}
