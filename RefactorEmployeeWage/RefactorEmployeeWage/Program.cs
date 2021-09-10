using System;

namespace RefactorEmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject emp = new EmpWageBuilderObject();

            emp.ComputeEmpWage("Dmart", 20, 100, 10);
            emp.ComputeEmpWage("Relience", 10, 20, 4);


        }
    }
}
