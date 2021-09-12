using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorEmployeeWage
{
    class compute
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public compute(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public void allDetails()
        {
            Console.WriteLine("Company name : " + this.company);
            Console.WriteLine("Total Emp Wage for company  " + this.company + " is : " + this.totalEmpWage);
            Console.WriteLine("--------------------------------");
        }
    }
}

