using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorEmployeeWage
{
   
    public class EmpWageBuilderObject
    {
        // Declare Constant
        public const int Full_Time = 1;
        public const int Part_Time = 2;

        string company;
        int Emp_rate_per_Hrs;
        int Max_Working_Hrs;
        int Max_Working_Days;
        public int TotalempWage;

        //Create a Constructor
        public EmpWageBuilderObject(string company, int Emp_rate_per_Hrs, int Max_Working_Hrs, int Max_Working_Days)
        {
            this.company = company;
            this.Emp_rate_per_Hrs = Emp_rate_per_Hrs;
            this.Max_Working_Hrs = Max_Working_Hrs;
            this.Max_Working_Days = Max_Working_Days;
        }
       
        // Create a Method
        public void ComputeEmpWage()
        {
            // Variable declaration
            int No_of_Working_Days = 0;
            int empHrs = 0;
            int workingHrs = 0;
            while (No_of_Working_Days < Max_Working_Days && workingHrs < Max_Working_Hrs)
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
                Console.WriteLine("Days: " + No_of_Working_Days + " Emp Hrs: " + empHrs);
            }
            //Calculate Total Employee Wage
            TotalempWage = empHrs * Emp_rate_per_Hrs;
            Console.WriteLine("Total Emp Wage For Company: " + company + " is " + TotalempWage);
        }

    }
    
}
