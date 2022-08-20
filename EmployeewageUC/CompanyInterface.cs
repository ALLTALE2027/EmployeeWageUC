using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageUC
{  //UC11
    internal class CompanyInterface
    {
        internal interface ICompanyWage
        {
            void CalculateWage();
            void GetWage();

        }

        internal class MultipleEmpWageBuilder : ICompanyWage

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

            public void CalculateWage()
            {
                for (int i = 0; i < this.multipleEmployee.Length; i++)
                {

                    multipleEmployee[i].CalculateWage();
                }
            }


            public void GetWage()
            {
                for (int i = 0; i < this.multipleEmployee.Length; i++)
                {
                    Console.WriteLine(this.multipleEmployee[i].GetWage());

                }
            }
        }
    }
}
