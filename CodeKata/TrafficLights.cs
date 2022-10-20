using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class TrafficLights
    {
        public static string UpdateLight(string current)
        {
            switch (current)
            {
                case "green":
                    return "yellow";
                case "yellow":
                    return "red";
                case "red":
                    return "green";
                default:
                    return "";
            }
        }
    }
}
