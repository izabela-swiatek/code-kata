using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class SumArrayWithoutExtremes
    {
        public static int Sum(int[] numbers)
        {
            int sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;

            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                var current = numbers[i];

                min = current < min ? current : min;
                max = current > max ? current : max;
                sum += current;
            }

            return sum - (min + max);

        }
    }
}
