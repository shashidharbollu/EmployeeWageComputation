using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        const int PART_TIME_EMP = 1, FULL_TIME_EMP = 2, EMP_WAGE_PR_HR = 20, EMP_FULL_DAY_WRKING_HR = 8, EMP_PART_TIME_WRKING_HR = 4;
        
        //variable values
        int empHrs = 0;
        int oneDayEmpSalary = 0;

        public void dailyEmpWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == FULL_TIME_EMP)
            {
                Console.WriteLine("Employee Working As A full Time");
                empHrs = EMP_FULL_DAY_WRKING_HR;
            }
            else if (empCheck == PART_TIME_EMP)
            {
                Console.WriteLine("Employee Working As Part TIme");
                empHrs = EMP_PART_TIME_WRKING_HR;
            }

            else
            {
                empHrs = 0;
            }
            oneDayEmpSalary = empHrs * EMP_WAGE_PR_HR;
            Console.WriteLine("One Day Employee salary is :" + oneDayEmpSalary);
        }
    }
}