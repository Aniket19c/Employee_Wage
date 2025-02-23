using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write("Enter your working hours (4 or 8 allowed): ");
            int workHours = Convert.ToInt32(Console.ReadLine());
            int earnings = 0;
            int hourlyRate = 20;

            if (workHours == 4)
            {
                Console.WriteLine("You have completed part-time work.");
                earnings = workHours * hourlyRate;
            }
            else if (workHours == 8)
            {
                Console.WriteLine("Well done! You have completed a full day's work.");
                earnings = workHours * hourlyRate;
            }
            else if (workHours > 0 && workHours < 8)
            {
                Console.WriteLine("Invalid entry. Please enter either 4 (part-time) or 8 (full-time) hours.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of working hours.");
            }

            Console.WriteLine($"Your total wage is: Rs {earnings}/-");
        }
    }
}
