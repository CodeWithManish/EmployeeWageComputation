using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int EMP_PRESENT = 0, EMP_ABSENT = 1;
        public void EmpAttendence()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");

            }
            if (empcheck == EMP_ABSENT)
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
