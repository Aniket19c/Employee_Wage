using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the company name: ");
            string organization = Console.ReadLine();
            Console.Write("Enter total working days: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter maximum hours in a month: ");
            int maxMonthlyHours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter hourly wage rate: ");
            int wageRate = Convert.ToInt32(Console.ReadLine());

            WageCalculator worker = new WageCalculator(organization, totalDays, maxMonthlyHours, wageRate);
            int computedSalary = worker.CalculateTotalEarnings();
            Console.WriteLine($"\nTotal earnings for {organization}: Rs{computedSalary}/-");
        }
    }
}

class WageCalculator
{
    private string organizationName;
    private int maxWorkDays;
    private int maxAllowedHours;
    private int hourlyWage;

    public WageCalculator(string organizationName, int maxWorkDays, int maxAllowedHours, int hourlyWage)
    {
        this.organizationName = organizationName;
        this.maxWorkDays = maxWorkDays;
        this.maxAllowedHours = maxAllowedHours;
        this.hourlyWage = hourlyWage;
    }

    public int CalculateTotalEarnings()
    {
        int accumulatedHours = 0;
        int overallSalary = 0;
        int dayCounter = 0;

        Console.WriteLine($"\nComputing salary for {organizationName}\n");

        while (accumulatedHours < maxAllowedHours && dayCounter < maxWorkDays)
        {
            Console.Write("Enter hours worked for today (Max 8): ");
            int dailyHours = Convert.ToInt32(Console.ReadLine());

            if (dailyHours < 0 || dailyHours > 8)
            {
                Console.WriteLine("Invalid input. Please enter a value between 0 and 8.");
                continue;
            }

            int dailyWage = dailyHours * hourlyWage;
            overallSalary += dailyWage;
            accumulatedHours += dailyHours;
            dayCounter++;

            Console.WriteLine($"Day {dayCounter}: Worked {dailyHours} hours, Earned: Rs {dailyWage}/-, Cumulative Earnings: Rs {overallSalary}/-");
        }

        Console.WriteLine($"\nWork Limit Reached for {organizationName}!");
        Console.WriteLine($"Total Days Worked: {dayCounter}, Total Hours Worked: {accumulatedHours}, Final Monthly Wage: Rs {overallSalary}/-");

        return overallSalary;
    }
}
