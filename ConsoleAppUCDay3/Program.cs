using System;

namespace ConsoleAppUCDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Enter 0 for welcome program \n Enter 1 for Employee Attendance UC1 \n Enter 2 for Calculating Employee Wage UC2 \n Enter 3 for Calculating Employee Wage By Adding Part-time UC3 \n Enter 4 for Calculating Employee Wage By Adding Part-time Using Case UC4");
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
                case 2:
                    int empCheck2 = random.Next(0, 2);
                    EmployeeWadgeUC2.EmployeeUC2(empCheck2);
                    break;
                case 3:
                    int empCheck3 = random.Next(0, 3);
                    EmployeeWadgeUC3.EmployeeUC3(empCheck3);
                    break;
                case 4:
                    int empCheck4 = random.Next(0, 3);
                    EmployeeWadgeUC4.EmployeeUC4(empCheck4);
                    break;
                default:
                    Console.WriteLine("Please Input Correct option");
                    break;

            }
        }
    }
}
