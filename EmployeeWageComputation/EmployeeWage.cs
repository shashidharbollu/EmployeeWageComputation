using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeWage
    {
        //constance value
        const int PART_TIME_EMP = 1, FULL_TIME_EMP = 2, EMP_FULL_DAY_WRKING_HR = 8, EMP_PART_TIME_WRKING_HR = 4;


        //variable values
        int empHrs = 0;
        int totalEmpSalary = 0;
        int totalEmpHrs = 0;
        int day = 0;

        public void monthlyWage(string company_Name, int emp_Wage_Pr_Hr, int Emp_Working_Hr, int Emp_Working_Days_Pr_Month, int max_Working_Hrs)
        {
            while (day <= Emp_Working_Days_Pr_Month && empHrs <= max_Working_Hrs)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {

                    case FULL_TIME_EMP:

                        empHrs += EMP_FULL_DAY_WRKING_HR;
                        break;

                    case PART_TIME_EMP:
                        empHrs += EMP_PART_TIME_WRKING_HR;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                day++;
            }
            totalEmpSalary = empHrs * emp_Wage_Pr_Hr;
            Console.WriteLine("the salary of the employee is : " + totalEmpSalary);
        }
    }
}