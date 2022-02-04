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
            EmployeeWage dMart = new EmployeeWage("DMart",20,2,10);
            EmployeeWage relience = new EmployeeWage("Relience",10,4,20);
            dMart.EmpAttendence();
            Console.WriteLine(dMart.ToString());
            relience.EmpAttendence();
            Console.WriteLine(relience.ToString());
              
            

        }
    }
}
