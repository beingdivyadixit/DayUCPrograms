using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUCDay3
{
    internal class EmployeeWadgeUC4
    {
        public static void EmployeeUC4(int empCheck4)
        {
            int EMP_RATE_PER_HOUR = 20;
            int empWadge = 0, empHr = 0;

            switch (empCheck4)
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
            Console.WriteLine("Employee Wadge:" + empWadge);
        }
    }
}
