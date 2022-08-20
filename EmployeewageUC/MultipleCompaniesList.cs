using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageUC
{
    internal class MultipleCompaniesList
    {
        private List<EmpWageBuilder> _companyArray;
        public MultipleCompaniesList()
        {
            this._companyArray = new List<EmpWageBuilder>();
        }
        public void AddCompany(string company, int workingDays, int wagePerHour, int totalWorkingHrs)
        {
            EmpWageBuilder obj = new EmpWageBuilder(company, workingDays, wagePerHour, totalWorkingHrs);
            this._companyArray.Add(obj);
        }
        public void WageCalculation()
        {
            foreach (var empObj in _companyArray)
            {
                empObj.CalculateWage();
            }
        }

        public void GetMonthlyWage()
        {
            foreach (var empObj in _companyArray)
            {
                Console.WriteLine(empObj.GetWage());

            }
        }
    }
}
