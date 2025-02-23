using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Enter daily working hours (1-8): ");
            int dailyHours = Convert.ToInt32(Console.ReadLine());
            int hourlyWage = 20;
            int workDays = 20;

            if (dailyHours < 1 || dailyHours > 8)
            {
                Console.WriteLine("Invalid input. Please enter hours between 1 to 8.");
            }
            else
            {
                int monthlySalary = dailyHours * hourlyWage * workDays;
                Console.WriteLine($"Based on {dailyHours} hours per day, your total monthly wage is: Rs {monthlySalary}/-");
            }
        }
    }
}
