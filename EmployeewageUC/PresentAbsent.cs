using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageUC
{
    internal class PresentAbsent
    {
        public void presentAbsent()
        {
            //---------------- UC1- check Employee is present or absent -------------------//

            Console.WriteLine("UC1-Employee present or absent");
            Random random = new Random();
            int empCheck = random.Next(0, 3); // it will give values 1 and 2 and not 3
            int isFullTime = 1;
            if (empCheck == isFullTime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }


        }
    }
}
