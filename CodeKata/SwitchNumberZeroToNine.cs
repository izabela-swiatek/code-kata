using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class SwitchNumberZeroToNine
    {
        public static string SwitchItUp(int number)
        {
            var result = number switch
            {
                0 => "Zero",
                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                5 => "Five",
                6 => "Six",
                7 => "Seven",
                8 => "Eight",
                9 => "Nine",
                _ => "Invalid number"
            };

            return result;
        }

    }
}
