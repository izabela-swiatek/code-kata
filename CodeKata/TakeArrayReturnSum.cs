using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class TakeArrayReturnSum
    {
        public static double SumArray(double[] array)
        {
            double output = 0;

            for (int i = 0; i < array.Length; i++)
            {
                output += array[i];
            }

            return output;
        }
    }
}
