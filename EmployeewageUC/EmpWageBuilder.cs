using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageUC
{
    internal class EmpWageBuilder
    {
        const int isFullTime = 1;
        const int isPartTime = 2;
        int totalWage = 0;


        public List<int> empDailyWages;
        public string company;
        private int workingDays;
        private int wagePerHour;
        private int totalWorkingHrs;




        public EmpWageBuilder(string company, int workingDays, int wagePerHour, int totalWorkingHrs)
        {
            this.company = company;
            this.workingDays = workingDays;
            this.wagePerHour = wagePerHour;
            this.totalWorkingHrs = totalWorkingHrs;
            this.empDailyWages = new List<int>();
        }

        public void CalculateWage()
        {
            int empHrs;
            int dailyWage;
            int totalNoOfHrs = 0;
            int totalWorkingDays = 0;

            Random random = new Random();
            while (totalWorkingDays < this.workingDays && totalNoOfHrs <= this.totalWorkingHrs)
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
                empDailyWages.Add(dailyWage);
                totalWage += dailyWage;
                totalWorkingDays++;

                if (totalNoOfHrs > this.totalWorkingHrs)
                    totalNoOfHrs -= empHrs;
            }


            Console.WriteLine("Total No of hours are {0} and working days are {1} in {2} company", totalNoOfHrs, totalWorkingDays, this.company);
        }

        public string GetWage()
        {
            return "Total monthly wage of a person working in " + this.company + " company is : " + this.totalWage;
        }


        public void ReturnDailyWage()
        {
            Console.WriteLine("Daily wages of employee working in {0} company are:", this.company);
            foreach (var i in empDailyWages)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
