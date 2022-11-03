using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class FindFirstNonConsecutive
    {
        public static object FirstNonConsecutive(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int previousNum = arr[i - 1];
                int currentNum = arr[i];

                if (currentNum != previousNum + 1)
                    return currentNum;
            }
            return null;
        }
    }
}
