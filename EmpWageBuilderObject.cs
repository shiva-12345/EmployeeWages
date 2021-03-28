using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private String company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;

        }
        public void computeEmpWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (empHrs <= this.maxHoursPerMonth && totalWorkingDays <= this.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();

                int empCheck = random.Next(0, 3);
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
                Console.WriteLine("Days:" + totalWorkingDays + "emp Hrs:" + empHrs);
            }

            int totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company  " + company + " is : " + totalEmpWage);

            String toString()
            {
                return "Tatal Emp Wage For Company " + this.company + " is :" + totalEmpWage;
            }

        }
    }
}