using System;

namespace RefactorEmployeeWage
{
    class Program
    {
        static int Full_Time = 1;
        static int Part_Time = 2;
        static int Emp_rate_per_Hrs = 20;
        static int empHrs, empWage;
        static int Max_Working_Days = 20;
        static int Max_Working_Hrs = 100;
        static int totalEmpWage = 0;
        static int workingHrs = 0;
        static int No_of_Working_Days = 0;
        static int Attendance()
        {
            while (No_of_Working_Days <= Max_Working_Days && workingHrs <= Max_Working_Hrs)
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
            return empWage;
        }
        static void Main(string[] args)
        {
            Attendance();
            Console.WriteLine("Employee Wages: " + empWage);
            
        }
    }
}
