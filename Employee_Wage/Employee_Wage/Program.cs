using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WageCalculator worker = new WageCalculator(20, 22, 160);
            worker.ComputeSalary();
        }
    }
}

public class WageCalculator
{
    private int ratePerHour;
    private int maxDays;
    private int maxHours;

    public WageCalculator(int ratePerHour, int maxDays, int maxHours)
    {
        this.ratePerHour = ratePerHour;
        this.maxDays = maxDays;
        this.maxHours = maxHours;
    }

    public void ComputeSalary()
    {
        int totalSalary = 0;
        int workedHours = 0;
        int workedDays = 0;

        while (workedHours < maxHours && workedDays < maxDays)
        {
            Console.Write("Enter hours worked for today (Max 8 hours): ");
            int dailyHours = Convert.ToInt32(Console.ReadLine());

            if (dailyHours < 0 || dailyHours > 8)
            {
                Console.WriteLine("Invalid input. Please enter a value between 0 and 8.");
                continue;
            }

            int dailyIncome = dailyHours * ratePerHour;
            totalSalary += dailyIncome;
            workedHours += dailyHours;
            workedDays++;

            Console.WriteLine($"Day {workedDays}: Worked {dailyHours} hours, Earned: {dailyIncome}, Total Earnings: Rs {totalSalary}/-");
        }

        Console.WriteLine("\nWork Hour Limit Reached!");
        Console.WriteLine($"Total days worked: {workedDays}, Total hours worked: {workedHours}, Total monthly wage: Rs {totalSalary}/-");
    }
}
