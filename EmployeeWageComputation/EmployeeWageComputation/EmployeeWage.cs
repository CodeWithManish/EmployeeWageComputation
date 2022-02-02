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
            FULLDAYS_HOUR = 8, PART_TIME_HOUR = 4, WORKING_DAYS = 20;
        int wagePerMonth = 0;
        public void EmpAttendence()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            for (int i = 0; i < WORKING_DAYS; i++)
            {

                switch (empcheck)
                {
                    case FULL_TIME:
                        wagePerMonth += WAGE_PER_HOUR * FULLDAYS_HOUR;
                        break;

                    case PART_TIME:
                        wagePerMonth += WAGE_PER_HOUR * PART_TIME_HOUR;
                        break;

                    default:

                        break;

                }
            }
            Console.WriteLine("Monthy wage of Employee is " + wagePerMonth);
        }
    }
}
