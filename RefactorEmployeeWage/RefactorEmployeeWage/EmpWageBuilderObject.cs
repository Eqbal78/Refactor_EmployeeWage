using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorEmployeeWage
{

    public interface IEmployee
    {
         void ComputeEmpWage(string company, int Emp_rate_per_Hrs, int Max_Working_Hrs, int Max_Working_Days);
    }
   
    public class EmpWageBuilderObject
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
       
        static int No_of_Working_Days=0;

        public void ComputeEmpWage(string company, int Emp_rate_per_Hrs, int Max_Working_Hrs, int Max_Working_Days)
        {
            int empHrs = 0, empWage, workingHrs = 0; ;
            while (No_of_Working_Days <= Max_Working_Days && workingHrs < Max_Working_Hrs)
            {
                No_of_Working_Days++;
                Random r = new Random();
                int check = r.Next(1, 4);
                switch (check)
                {
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                workingHrs += empHrs;
                Console.WriteLine("Days: " + workingHrs + " Emp Hrs: " + empHrs);
            }
            empWage = empHrs * Emp_rate_per_Hrs;
            Console.WriteLine("Total Emp Wage For Company: " + company + " is " + empWage);
        }
    }
    
}
