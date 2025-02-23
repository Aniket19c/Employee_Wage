using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int payPerHour = 20;
            int maxMonthlyHours = 160;
            int maxWorkDays = 22;
            int cumulativeSalary = 0;
            int hoursAccumulated = 0;
            int daysCount = 0;

            while (hoursAccumulated < maxMonthlyHours && daysCount < maxWorkDays)
            {
                Console.Write("Enter today's work duration (Max 8 hours): ");
                int workTime = Convert.ToInt32(Console.ReadLine());

                if (workTime < 0 || workTime > 8)
                {
                    Console.WriteLine("Invalid entry. Please enter a value between 0 and 8.");
                    continue;
                }

                int dailyEarnings = workTime * payPerHour;
                cumulativeSalary += dailyEarnings;
                hoursAccumulated += workTime;
                daysCount++;

                Console.WriteLine($"Day {daysCount}: Worked {workTime} hours, Earned: {dailyEarnings}. Total Earnings: Rs {cumulativeSalary}/-");
            }

            Console.WriteLine("\nMonthly Work Limit Reached!");
            Console.WriteLine($"Total days worked: {daysCount}, Total hours worked: {hoursAccumulated}, Final Monthly Wage: Rs {cumulativeSalary}/-");
        }
    }
}
