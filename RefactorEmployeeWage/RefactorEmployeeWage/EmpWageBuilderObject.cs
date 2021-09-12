using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorEmployeeWage
{
   
    class EmpWageBuilderObject
    {
        //Initializing Constant Values
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public int numOfCompany = 0;
        //creating an array
        public compute[] ComputeArray;

        public EmpWageBuilderObject()
        {
            //giving count
            this.ComputeArray = new compute[5];
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //every index is object
            ComputeArray[this.numOfCompany] = new compute(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;//adding count of companys
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                ComputeArray[i].setTotalEmpWage(this.computeEmpWage(this.ComputeArray[i]));
                this.ComputeArray[i].allDetails();
            }
        }
        private int computeEmpWage(compute companyEmpWage)
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {

                Random random = new Random();
                int empCheck = random.Next(0, 3);
                totalWorkingDays++;
                //int empCheck = 1;
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
            //Console.WriteLine("Total Emp Wage for company : " + company + " is: " + totalEmpWage);
        }

    }
    
}
