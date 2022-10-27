using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class RemoveExclamation
    {
        public static string RemoveExclamationMarks(string givenString) 
        {
            return givenString.Replace("!", "");
        }
    }
}
