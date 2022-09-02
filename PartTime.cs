

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public  class Parttime
    {
        public  void EmpParttime()
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EmpHrs = 0;
            int Empwage = 0;
            int Emp_RATE_PER_HOUR = 20;
            Random random = new Random();
            int EmpCheck = random.Next(3);
            if (EmpCheck == IS_FULL_TIME)
            {
                EmpHrs = 8;
            }
            else if (EmpCheck == IS_PART_TIME)
            {
                EmpHrs = 4;
            }
            else
            {
                EmpHrs = 0;

            }
            Empwage = EmpHrs * Emp_RATE_PER_HOUR;
            Console.WriteLine("EmpWage:" + Empwage);


        }
    }
}



