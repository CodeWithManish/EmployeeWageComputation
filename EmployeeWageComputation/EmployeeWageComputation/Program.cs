using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Program
    {
        // drive method
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage Computation problem \n");
            EmployeeWage wageComputation = new EmployeeWage();
            wageComputation.EmpAttendence("Hero", 20, 2, 10);
            wageComputation = new EmployeeWage();
            wageComputation.EmpAttendence("Maruti", 10, 5, 30);
            wageComputation = new EmployeeWage();
            wageComputation.EmpAttendence("Relience", 10, 3, 4);    
            Console.ReadLine();
            

        }
    }
}
