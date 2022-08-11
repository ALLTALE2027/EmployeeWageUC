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
        }
    }
}