using EmployeeWageComputation;
using System;
    
   public class Program
{
    public static void Main(string[] args)
    { 
    EmployeeWage computation=new EmployeeWage();
        computation.monthlyWage("dmart",3,10,15,2);
        computation.monthlyWage("more", 4,5,6,4);
    }
}
