using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class ForTwentyDays
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int Emp_RATE_PER_HOUR = 20;
        public const int NO_OF_WORKING_DAYS = 20;

        public  void EmpWageSwitch()
        {

            int EmpHrs = 0;
            int Empwage = 0, TotalEmpWage = 0;
            for (int Day = 0; Day < NO_OF_WORKING_DAYS; Day++)
            {

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
                Empwage = EmpHrs * Emp_RATE_PER_HOUR;
                Console.WriteLine("EmpWage:" + Empwage);
            }


            Console.WriteLine("TotalEmpWage:" + TotalEmpWage);
        }






    }
}
