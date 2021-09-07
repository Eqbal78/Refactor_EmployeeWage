using System;

namespace practicEmployeeWage
{
    public interface IEmployee
    {
        public void ComputeEmpWage();
    }

    public class EmpWageBuilderObject : IEmployee
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        private int Emp_rate_per_Hrs;

        private int Max_Working_Days;
        private int Max_Working_Hrs;
        private int No_of_Working_Days;

        public EmpWageBuilderObject(int Emp_rate_per_Hrs, int Max_Working_Days, int Max_Working_Hrs, int No_of_Working_Days)
        {
            this.Emp_rate_per_Hrs = Emp_rate_per_Hrs;
            this.Max_Working_Days = Max_Working_Days;
            this.Max_Working_Hrs = Max_Working_Hrs;
            this.No_of_Working_Days = No_of_Working_Days;
        }

        public void ComputeEmpWage()
        {
            int empHrs = 0, empWage, workingHrs = 0; ;
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
            Console.WriteLine("Employee Wages: " + empWage);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject emp = new EmpWageBuilderObject(20, 20, 100, 0);
            emp.ComputeEmpWage();

        }
    }
}
