using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class ThirdTriangleAngle
    {
        public static int OtherAngle(int a, int b) 
        {
            return 180 > a + b ? 180 - a - b : 0;
        }
    }
}
