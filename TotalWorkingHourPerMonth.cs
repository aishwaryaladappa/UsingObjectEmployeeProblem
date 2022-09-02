using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public static class TotalWorkingHourPerMonth
    {


        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int Emp_RATE_PER_HOUR = 20;
        public const int NO_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        public static void TotalWorkingHrs()


        {

            int EmpHrs = 0;
            int TotalWorkingdays = 0, TotalEmpHrs = 0;
            while (TotalEmpHrs <= MAX_HRS_IN_MONTH && TotalWorkingdays < NO_OF_WORKING_DAYS)
            {
                TotalWorkingdays++;

                Random random = new Random();
                int EmpCheck = random.Next(3);
                switch (EmpCheck)
                {
                    case IS_FULL_TIME:
                        EmpHrs = 8;
                        break;
                    case IS_PART_TIME:
                        EmpHrs = 4;
                        break;
                    default:
                        EmpHrs = 0;
                        break;

                }

                TotalEmpHrs += EmpHrs;
                Console.WriteLine("Day#:" + TotalWorkingdays + "EmpHrs:" + EmpHrs);
            }
            int TotalempWage = TotalEmpHrs * Emp_RATE_PER_HOUR;

            Console.WriteLine("TotalEmpWage:" + TotalempWage);


        }
    }
}
