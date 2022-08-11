using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageUC
{
    internal class DailyWage
    {
        public void dailyWage()
        {
            //-----------------UC2-Calculate Daily Employee Wage--------------//

            Console.WriteLine("UC2-Calculate Daily Employee Wage");
            Random random = new Random();
            int empCheck = random.Next(1, 3);
            int isFullTime = 1;
            int wagePerHour = 20;
            int empHrs;
            int dailyWage;

            if (empCheck == isFullTime)
            {
                empHrs = 8;
                dailyWage = wagePerHour * empHrs;

                Console.WriteLine("Employee is present and his salary is: " + dailyWage);
            }
            else
            {
                empHrs = 0;
                dailyWage = wagePerHour * empHrs;
                Console.WriteLine("Employee is absent and his salary is: " + dailyWage);
            }

        }
    }
}
