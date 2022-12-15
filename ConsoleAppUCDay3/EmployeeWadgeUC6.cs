using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUCDay3
{
    internal class EmployeeWadgeUC6
    {
        public static void EmployeeUC6()
        {
            int EMP_RATE_PER_HOUR = 20, NUM_OF_WORKING_DAYS = 20, MAX_HRS_IN_MONTH = 100;
            int totalEmpHr = 0, empHr = 0, totalEmpWadge = 0, totalWorkingDays = 0;
            while (totalEmpHr <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
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
                totalEmpHr = totalEmpHr + empHr;
                totalWorkingDays++;
            }
            totalEmpWadge = totalEmpHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee Wadge For A Month:" + totalEmpWadge);
        }
    }
}
