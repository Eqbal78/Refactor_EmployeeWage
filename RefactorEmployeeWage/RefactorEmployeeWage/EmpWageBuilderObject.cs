using System;
using System.Collections;
using System.Text;

namespace RefactorEmployeeWage
{
    //Decleare Interface
    public interface IEmpWageBuilderArray
    {
        void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void computeEmpWage();
    }

    class EmpWageBuilderObject : IEmpWageBuilderArray
    {
        //Initializing Constant Values
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        //creating an array list
        public ArrayList ComputeArray;

        public EmpWageBuilderObject()
        {
            
            this.ComputeArray = new ArrayList();
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //creating object for CompanyEmpWage class
            compute companyEmp = new compute(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            //adding the object to list
            this.ComputeArray.Add(companyEmp);
        }
        public void computeEmpWage()
        {
            //check availability
            foreach (compute wage in ComputeArray)
            {
                wage.setTotalEmpWage(this.computeEmpWage(wage));
                wage.allDetails();
            }
        }
        public int computeEmpWage(compute companyEmpWage)
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
                Console.WriteLine("Day: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
            //Console.WriteLine("Total Emp Wage for company : " + company + " is: " + totalEmpWage);
        }

    }
    
}
