using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Input work duration (4 or 8 hours only): ");
            int workDuration = Convert.ToInt32(Console.ReadLine());
            int salary = 0;
            int ratePerHour = 20;

            switch (workDuration)
            {
                case 4:
                    Console.WriteLine("You have completed a part-time shift.");
                    salary = workDuration * ratePerHour;
                    break;
                case 8:
                    Console.WriteLine("Great effort! You have successfully completed a full-time shift.");
                    salary = workDuration * ratePerHour;
                    break;
                default:
                    Console.WriteLine("Invalid entry. Please input either 4 or 8 hours.");
                    break;
            }

            Console.WriteLine($"Your computed wage is: Rs {salary}/-");
        }
    }
}
