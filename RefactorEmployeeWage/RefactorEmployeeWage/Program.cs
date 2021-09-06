using System;

namespace RefactorEmployeeWage
{
    class Program
    {
        static int Full_Time = 1;
        static int Part_Time = 2;
        static int Emp_rate_per_Hrs = 20;
        static int empHrs, empWage;
        static int Attendance()
        {
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
