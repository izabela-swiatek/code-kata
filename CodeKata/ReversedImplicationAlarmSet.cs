using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class ReversedImplicationAlarmSet
    {
        public static bool SetAlarm(bool employed, bool vacation) 
        {
            return !(!employed | vacation);
        }
    }
}
