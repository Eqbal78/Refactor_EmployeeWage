using System;

namespace RefactorEmployeeWage
{
    class Program
    {
        static int Full_Time = 1;
        static int Part_Time = 2;
        static int Emp_rate_per_Hrs = 20;
        static int empHrs, empWage;
        static int No_Of_Working_Days = 20;
        static int totalEmpWage = 0;
        static int Attendance()
        {
            for (int i = 0; i < No_Of_Working_Days; i++)
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
                totalEmpWage += empWage;
            }
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            Attendance();
            //Console.WriteLine("Employee Wages: " + empWage);
            Console.WriteLine("Total Monthly Emp Wages: " + totalEmpWage);
        }
    }
}
