using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKata
{
    public class SalaryWhenBonus
    {
        public static string BonusTime(int salary, bool bonus)
        {
            int salaryAfterBonus = bonus ? salary * 10 : salary;
            return $"${salaryAfterBonus}";
        }
    }
}
