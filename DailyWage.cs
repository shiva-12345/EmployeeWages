using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class DailyWage
    {
        public static void dailyWage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUT = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            empWage = empHrs * EMP_RATE_PER_HOUT;

            Console.WriteLine("Emp Wage :" + empWage);
        }

    }
}