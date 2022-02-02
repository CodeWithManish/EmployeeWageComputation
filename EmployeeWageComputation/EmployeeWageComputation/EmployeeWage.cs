using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int EMP_PRESENT = 1, EMP_ABSENT = 0, WAGE_PER_HOUR = 20, FULLDAYS_HOUR = 8;
        int dailyEmployeeWage = 0;
        public void CalcEmployeeWage()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);

            if (empcheck == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                dailyEmployeeWage = WAGE_PER_HOUR * FULLDAYS_HOUR;
                Console.WriteLine(dailyEmployeeWage);
            }
            if (empcheck == EMP_ABSENT)
            {
                Console.WriteLine("Employee is Absent");

            }
        }
    }
}
