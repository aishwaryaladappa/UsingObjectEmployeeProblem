﻿
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeWageProblem
    {
        public  class EmployeePresentOrAbsent
        {
            public  void Attendance()
            {
                int IS_FULL_TIME = 1;
                Random random = new Random();
                int empCheck = random.Next(2);
                if (empCheck == IS_FULL_TIME)

                {
                    Console.WriteLine("employee is present");
                }
                else
                {
                    Console.WriteLine("employee is absent");
                }

            }
        }
    }


