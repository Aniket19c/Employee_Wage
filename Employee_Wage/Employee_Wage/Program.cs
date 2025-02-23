using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write("Enter the number of hours worked (max-8): ");
            int workDuration = Convert.ToInt32(Console.ReadLine());
            int totalWage;
            int payRate = 30;

            if (workDuration > 8)
            {
                Console.WriteLine("Invalid Input.");
                totalWage = 0;
            }
            else if (workDuration >= 5 && workDuration <= 8)
            {
                Console.WriteLine("Great job! Your efforts are recognized.");
                totalWage = workDuration * payRate;
            }
            else
            {
                Console.WriteLine("You need to contribute more work hours.");
                totalWage = 0;
            }

            Console.WriteLine($"Your total earnings: Rs {totalWage}/-");
        }
    }
}
