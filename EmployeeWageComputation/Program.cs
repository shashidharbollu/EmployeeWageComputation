using EmployeeWageComputation;
using System;
    
   public class Program
{
    public static void Main(string[] args)
    {
        EmployeeWage dmart = new EmployeeWage("Dmart" ,20,2,10);
        EmployeeWage reliance = new EmployeeWage("Relieance", 10, 4, 20);
        dmart.computeEmpWage();
        Console.WriteLine(dmart.toString());
        reliance.computeEmpWage();
        Console.WriteLine(reliance.toString());
    }
}
