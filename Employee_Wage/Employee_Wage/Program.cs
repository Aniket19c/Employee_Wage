using System;

namespace Employee_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Random random = new Random();
            int empCheck = random.Next(0, 2); 

            if (empCheck == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
