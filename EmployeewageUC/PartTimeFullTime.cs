﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageUC
{
    internal class PartTimeFullTime
    {
        public void partTimeFullTime()
        {

            //--------------------- UC3-Add Part time Employee & Wage -----------------//

            Console.WriteLine("UC3-Add Part time Employee & Wage");
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            int isFullTime = 1;
            int isPartTime = 2;
            int wagePerHour = 20;
            int empHrs;
            int dailyWage;

            if (empCheck == isFullTime)
            {
                empHrs = 8;
                dailyWage = wagePerHour * empHrs;

                Console.WriteLine("Employee is present for full time and his salary is: " + dailyWage);
            }
            else if (empCheck == isPartTime)
            {
                empHrs = 4;
                dailyWage = wagePerHour * empHrs;

                Console.WriteLine("Employee is present for Part time and his salary is: " + dailyWage);
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
