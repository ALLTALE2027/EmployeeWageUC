using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageUC
{
    internal class MultipleEmpWageBuilder
    {
        private int index = 0;
        private EmpWageBuilder[] multipleEmployee;
        
        public MultipleEmpWageBuilder()
        {
            this.multipleEmployee = new EmpWageBuilder[3];
        }

        public void AddCompany(string company, int workingDays, int wagePerHour, int totalWorkingHrs)
        {

            multipleEmployee[this.index++] = new EmpWageBuilder(company, workingDays, wagePerHour, totalWorkingHrs);
        }

        public void WageCalculation()
        {
            for (int i = 0; i < this.multipleEmployee.Length; i++)
            {

                multipleEmployee[i].CalculateWage();
            }
        }


        public void GetSalary()
        {
            for (int i = 0; i < this.multipleEmployee.Length; i++)
            {
                Console.WriteLine(this.multipleEmployee[i].GetWage());

            }
        }
    }
}
