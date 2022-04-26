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
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmployeeWage(String company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHourPerMonth;

        }
        public void computeEmpWage()
        {
            int totalWorkingDays = 0;
            int empHrs = 0;
            int totalEmpHrs = 0;

            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random obj = new Random();
                int num = obj.Next(0, 3);
                switch (num)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        break;

                    case Is_Part_Time:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days : {0} Emp Hours : {1}", totalWorkingDays, empHrs);

            }
            public string toString()
            {
                String myString = "Total Emp Wage for company : " + this.company + " is: " + this.totalEmpWage;
                return myString;
            }
        }
    }

