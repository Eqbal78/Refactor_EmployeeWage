using System;

namespace RefactorEmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            EmpWageBuilderObject obj = new EmpWageBuilderObject();
            obj.addCompanyEmpWage("Airtel", 20, 6, 100);
            obj.addCompanyEmpWage("Idea", 20, 5, 100);
            obj.computeEmpWage();

        }
    }
}
