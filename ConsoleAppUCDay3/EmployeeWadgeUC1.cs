using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUCDay3
{
    internal class EmployeeWadgeUC1
    {
        public static void EmployeeUC1(int empCheck1)
        {
            int IS_FULL_TIME = 1;
            if (empCheck1 == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is not Present");
            }
        }
    }
}
