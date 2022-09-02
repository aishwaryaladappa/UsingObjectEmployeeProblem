namespace EmployeeWageProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            EmployeePresentOrAbsent obj = new EmployeePresentOrAbsent();
            obj.Attendance();
            EmployeeWage obj1 = new EmployeeWage();
            obj1.Wage();
            Parttime obj2 = new Parttime();
            obj2.EmpParttime();
            ForTwentyDays obj4 = new ForTwentyDays();
            obj4.EmpWageSwitch();
            Switchcase obj5 = new Switchcase();
            obj5.EmpWageSwitch();
            TotalWorkingHourPerMonth totalWorkingHourPerMonth = new TotalWorkingHourPerMonth();
            totalWorkingHourPerMonth.TotalWorkingHrs();


        }
    }
}