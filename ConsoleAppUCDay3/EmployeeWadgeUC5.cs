﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUCDay3
{
    internal class EmployeeWadgeUC5
    {
        public static void EmployeeUC5()
        {
            int EMP_RATE_PER_HOUR = 20, NUM_OF_WORKING_DAYS = 20;
            int empWadge = 0, empHr = 0, totalEmpWadge = 0;
            for (int i = 0; i < NUM_OF_WORKING_DAYS; i++)
            {
                Random random = new Random();
                int empCheck5 = random.Next(0, 3);
                switch (empCheck5)
                {
                    case 0:
                        empHr = 8;
                        break;

                    case 1:
                        empHr = 4;
                        break;
                    default:
                        empHr = 0;
                        break;

                }
                empWadge = empHr * EMP_RATE_PER_HOUR;
                totalEmpWadge = totalEmpWadge + empWadge;
            }

            Console.WriteLine("Total Employee Wadge For A Month:" + totalEmpWadge);
        }
    }
}
