using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int EMP_PRESENT = 1, EMP_ABSENT = 0, PART_TIME = 0, FULL_TIME = 1, WAGE_PER_HOUR = 20,
             FULLDAYS_HOUR = 8, PART_TIME_HOUR = 4;

        int wagePerDay = 0;

        public void EmpAttendence()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 3);

            if (empcheck == PART_TIME_HOUR)
            {
                Console.WriteLine("Part Time Employee is");
                wagePerDay = WAGE_PER_HOUR * PART_TIME_HOUR;

            }
            if (empcheck == FULLDAYS_HOUR)
            {
                Console.WriteLine("Employee is present");
                wagePerDay = WAGE_PER_HOUR * FULLDAYS_HOUR;

            }

            if (empcheck == EMP_ABSENT)
            {
                wagePerDay = 0;
            }
            Console.WriteLine("Employee wage: " + wagePerDay);
        }
    }
}
