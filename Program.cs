using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");

            EmpWageForMultipleComp employee = new EmpWageForMultipleComp();
            employee.computeEmpwage("DMart", 20, 2, 10);
            employee.computeEmpwage("Reliance", 10, 4, 20);
            Console.ReadLine();
          
        }
    }
}
