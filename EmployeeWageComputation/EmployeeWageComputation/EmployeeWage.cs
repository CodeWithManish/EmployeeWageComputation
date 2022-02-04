using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        
        const int IS_PART_TIME = 1, IS_FULL_TIME = 2;


        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmployeeWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numofWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void EmpAttendence()
        {
            int empHours = 0;
            int totalEmpHours = 0;
            int totalWorkingDays = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 3);

            //loop

            while (totalWorkingDays < numOfWorkingDays && totalEmpHours <= maxHoursPerMonth)
            {
                totalWorkingDays++;

                //Using Switch case
                switch (empcheck)
                {
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;

                    case IS_PART_TIME:
                        empHours = 4;
                        break;

                    default:
                        empHours = 0;
                        break;

                }
                totalEmpHours += empHours;
                Console.WriteLine("Days: " + totalWorkingDays + " Employee Hours: " + empHours);
            }
            int totalEmpWage = totalEmpHours * empRatePerHour;
            Console.WriteLine("Total Employee Wage for Company:" + company + " is: " + totalEmpWage);
            
        }
        public string tostring()
        {
            return "Total Emp Wage for company: " + this.company + "is:" + this.totalEmpWage;


        }
    }
}
