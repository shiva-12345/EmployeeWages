using System;

namespace EmployeeWages
{
    class Program
    {
        public static void Main()
        {
            EmpWageBuilderObject DMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            DMart.computeEmpWage();
            EmpWageBuilderObject Relaince = new EmpWageBuilderObject("Relaince", 10, 4, 20);
            Relaince.computeEmpWage();
        }
    }
}
