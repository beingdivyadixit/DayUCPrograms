using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUCDay3
{
    internal class EmployeeWadgeUC3
    {
        public static void EmployeeUC3(int empCheck3)
        {
            int IS_FULL_TIME = 1, IS_PART_TIME = 2, EMP_RATE_PER_HOUR = 20;
            int empWadge = 0, empHr = 0;

            if (empCheck3 == IS_FULL_TIME)
            {
                empHr = 8;
            }
            else if (empCheck3 == IS_PART_TIME)
            {
                empHr = 4;
            }
            else
            {
                empHr = 0;
            }
            empWadge = empHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wadge:" + empWadge);
        }
    }
}
