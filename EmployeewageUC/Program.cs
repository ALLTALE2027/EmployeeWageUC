﻿namespace EmployeewageUC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program !!!");

            //UC-1
            //PresentAbsent empPresentAbsent = new PresentAbsent();
            //empPresentAbsent.presentAbsent();

            //UC-2
            //DailyWage empDailyWage = new DailyWage();
            //empDailyWage.dailyWage();


            //UC-3
            //PartTimeFullTime empPartTimeFullTime = new PartTimeFullTime();
            //empPartTimeFullTime.partTimeFullTime();

            //UC-4
            //SwitchCase empSwitchCase = new SwitchCase();
            //empSwitchCase.UsingSwitch();

            //UC-5
            //WagePerMonth empWagesPerMonth = new WagePerMonth();
            //empWagesPerMonth.PerMonthWage();

            //UC-6
            //TotalWorkHrs100Days20 empTotalWorkHrs100Days20 = new TotalWorkHrs100Days20();
            //empTotalWorkHrs100Days20.WorkHrs100Days20();

            //UC-7 
            //ComputeEmployeeWage computeWage=new ComputeEmployeeWage();
            //computeWage.CalculateEmpWage();


            //UC-8
            //MultipleCompany muliplCompany=new MultipleCompany();
            //muliplCompany.WageMultipleCompany("Tesla",50,25,150);
            //muliplCompany.WageMultipleCompany("SpaceX",80,20,200);

            //UC-9
            //var uc9 = new EmpWageBuilder("Kingfisher", 30, 40, 100);
            //uc9.CalculateWage();
            //Console.WriteLine(uc9.GetWage());

            //UC10
            //var companyArray = new MultipleEmpWageBuilder();
            //companyArray.AddCompany("Indigo", 30, 25, 150);
            //companyArray.AddCompany("Kingfisher", 30, 40, 111);
            //companyArray.AddCompany("AirIndia", 25, 50, 150);
            //companyArray.WageCalculation();
            //companyArray.GetSalary();

            //UC11
            //var company_Interface = new MultipleEmpWageBuilder();
            //company_Interface.AddCompany("ABC", 30, 25, 150);
            //company_Interface.AddCompany("XYZ", 30, 40, 100);
            //company_Interface.AddCompany("UVW", 25, 50, 150);
            //company_Interface.WageCalculation();
            //company_Interface.GetSalary();


            //UC12
            //var companyList = new MultipleCompaniesList();
            //companyList.AddCompany("Indigo", 30, 25, 150);
            //companyList.AddCompany("Kingfisher", 30, 40, 111);
            //companyList.AddCompany("AirIndia", 25, 50, 150);
            //companyList.WageCalculation();
            //companyList.GetMonthlyWage();

            //UC13
            var uc13 = new MultipleCompaniesList();
            uc13.AddCompany("Indigo", 30, 25, 150);
            uc13.AddCompany("Kingfisher", 20, 40, 100);
            uc13.AddCompany("AirIndia", 25, 50, 120);
            uc13.WageCalculation();
            uc13.GetDailyWages();
            uc13.GetMonthlyWage();
        }
    }
}