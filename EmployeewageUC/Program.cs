namespace EmployeewageUC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program !!!");

            //UC-1
            PresentAbsent empPresentAbsent = new PresentAbsent();
            empPresentAbsent.presentAbsent();

            //UC-2
            DailyWage empDailyWage = new DailyWage();
            empDailyWage.dailyWage();


            //UC-3
            PartTimeFullTime empPartTimeFullTime = new PartTimeFullTime();
            empPartTimeFullTime.partTimeFullTime();
            //UC-4
            SwitchCase empSwitchCase = new SwitchCase();
            empSwitchCase.UsingSwitch();

            //UC-5
            WagePerMonth empWagesPerMonth = new WagePerMonth();
            empWagesPerMonth.PerMonthWage();
        }
    }
}