using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Computation problem \n");
            EmployeeWage wageComputation = new EmployeeWage();
            wageComputation.EmpAttendence();
            

        }
    }
}
