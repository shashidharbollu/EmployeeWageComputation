using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1;
        const int EMP_SAL_PER_HOURS = 40;
        int empHrs = 0;
        int empWage = 0;
        public void empSalary()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == IS_PRESENT)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_SAL_PER_HOURS;
            Console.WriteLine("Employee Salary is " + empWage + "rupee");

        }


    }
}
