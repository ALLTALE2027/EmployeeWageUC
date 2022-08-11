using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageUC
{
    internal class TotalWorkHrs100Days20
    {
        public void WorkHrs100Days20()
        {
            //------------------------ UC6-Calculate Wages till a condition of total working hours or days is reached for a month  ----------//
            Console.WriteLine("UC6-Calculating Wages for 100hrs or 20 days");
            Random random = new Random();

            const int isFullTime = 1;
            const int isPartTime = 2;

            int wagePerHour = 20;
            int empHrs;
            int dailyWage;
            int totalWage = 0;
            int workingDays = 20;
            int totalNoOfHrs = 0;
            int totalWorkingDays = 0;
            while (totalWorkingDays < workingDays && totalNoOfHrs <= 100)
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

                totalNoOfHrs += empHrs;
                dailyWage = wagePerHour * empHrs;
                totalWage = totalWage + dailyWage;
                totalWorkingDays++;
            }
            Console.WriteLine("Total Wage for Month is: " + totalWage);
            Console.WriteLine("Total No of hours are {0} and working days are {1}", totalNoOfHrs, totalWorkingDays);


        }
    }
}
