using System;

namespace RefactorEmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            EmpWageBuilderObject dmart = new EmpWageBuilderObject("Dmart",20,50,10);
            EmpWageBuilderObject flipkart = new EmpWageBuilderObject("Flipkart", 10, 60, 20);
            dmart.ComputeEmpWage();
            //Console.WriteLine(dmart.ToString());
            flipkart.ComputeEmpWage();
            //Console.WriteLine(flipkart.ToString());

        }
    }
}
