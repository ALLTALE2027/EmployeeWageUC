using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageUC
{
    internal class MultipleCompany
    {
        const int isFullTime = 1;
        const int isPartTime = 2;
        int dailyWage;

        public void WageMultipleCompany(string company, int wagePerHour, int workingDays, int totalWorkingHrs)
        {
            int empHrs;
            int totalWage = 0;
            int totalNoOfHrs = 0;
            int totalWorkingDays = 0;

            Random random = new Random();
            while (totalWorkingDays < workingDays && totalNoOfHrs <= totalWorkingHrs)
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
                totalWage += dailyWage;
                totalWorkingDays++;
            }
            Console.WriteLine("Total month  Wage for person from {0} company is {1} rupees : ", company, totalWage);
            Console.WriteLine("Total No of hours are {0} and working days are {1}", totalNoOfHrs, totalWorkingDays);


        }
    }
}
