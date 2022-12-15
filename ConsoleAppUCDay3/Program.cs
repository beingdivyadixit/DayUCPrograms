using System;

namespace ConsoleAppUCDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Enter 0 for welcome program \n Enter 1 for Employee Attendance");
            int option = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            switch (option)
            {

                case 0:
                    Console.WriteLine("Welcome to Employee Wage Computation Program");
                    break;
                case 1:
                    int empCheck1 = random.Next(0, 2);
                    EmployeeWadgeUC1.EmployeeUC1(empCheck1);
                    break;
                default:
                    Console.WriteLine("Please Input Correct option");
                    break;

            }
        }
    }
}
