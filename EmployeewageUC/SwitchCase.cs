using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageUC
{
    internal class SwitchCase
    {
        public void UsingSwitch()
        {
            //--------------------- UC4-Solving using Switch Case Statement --------------//

            Console.WriteLine("UC4-Solving using Switch Case Statement");
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            const int isFullTime = 1;
            const int isPartTime = 2;
            int wagePerHour = 20;
            int empHrs;
            int dailyWage;

            switch (empCheck)
            {
                case isFullTime:
                    empHrs = 8;
                    dailyWage = wagePerHour * empHrs;

                    Console.WriteLine("Employee is present for full time and his salary is: " + dailyWage);
                    break;

                case isPartTime:
                    empHrs = 4;
                    dailyWage = wagePerHour * empHrs;

                    Console.WriteLine("Employee is present for Part time and his salary is: " + dailyWage);
                    break;

                default:
                    empHrs = 0;
                    dailyWage = wagePerHour * empHrs;
                    Console.WriteLine("Employee is absent and his salary is: " + dailyWage);
                    break;

            }
        }
    }
}
