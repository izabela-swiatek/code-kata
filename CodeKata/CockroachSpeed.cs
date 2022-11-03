using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class CockroachSpeed
    {
        public static int SpeedCmPerH(double x)
        {
            double cmPerSec = 100000d / 3600d;
            return (int)(x * cmPerSec);
        }
    }
}
