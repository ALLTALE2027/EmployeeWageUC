using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageUC
{
    internal class WagePerMonth
    {

        public void PerMonthWage()
        {
            //---------------------- UC5-Calculating Wages for a Month -------------------------------//

            Console.WriteLine("UC5-Calculating Wages for a Month");
            Random random = new Random();

            const int isFullTime = 1;
            const int isPartTime = 2;
            int wagePerHour = 20;
            int empHrs;
            int dailyWage;
            int totalWage = 0;
            int workingDays = 20;


            int i = 0;
            while (i < workingDays)
            {
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case isFullTime:
                        empHrs = 8;

                        break;
                    case isPartTime:
                        empHrs = 4;

                        break;
                    default:
                        empHrs = 0;

                        break;

                }
                dailyWage = wagePerHour * empHrs;
                totalWage = totalWage + dailyWage;
                i++;
            }
            Console.WriteLine("Total Wage for Month is: " + totalWage);


        }
    }
}
