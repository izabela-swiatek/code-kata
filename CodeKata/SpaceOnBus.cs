using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class SpaceOnBus
    {
        public static int Enough(int cap, int on, int wait)
        {
            int isEnough = cap - on - wait;
            return isEnough > 0 ? 0 : Math.Abs(isEnough);
        }
    }
}
