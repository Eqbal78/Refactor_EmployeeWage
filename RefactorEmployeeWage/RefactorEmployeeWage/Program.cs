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
            if (check == Full_Time)
            {
                empHrs = 8;
            }
            else if (check == Part_Time)
            {
                empHrs = 4;
            }
            else
                empHrs = 0;

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
