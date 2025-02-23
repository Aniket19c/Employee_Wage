using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of companies: ");
            int companyCount = Convert.ToInt32(Console.ReadLine());

            WageManager[] companyWages = new WageManager[companyCount];

            for (int i = 0; i < companyCount; i++)
            {
                Console.Write($"\nEnter details for company {i + 1}:\n");
                Console.Write("Enter company name: ");
                string orgName = Console.ReadLine();
                Console.Write("Enter total working days: ");
                int totalDays = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter maximum hours per month: ");
                int maxHours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter hourly wage rate: ");
                int payRate = Convert.ToInt32(Console.ReadLine());

                companyWages[i] = new WageManager(orgName, totalDays, maxHours, payRate);
            }

            Console.WriteLine("\nCalculating wages for all companies:\n");

            foreach (var company in companyWages)
            {
                int finalSalary = company.ComputeEarnings();
                Console.WriteLine($"Total wage for {company.GetCompanyName()}: Rs{finalSalary}/-");
            }
        }
    }
}

interface ICompanyWage
{
    int ComputeEarnings();
    string GetCompanyName();
}

class WageManager : ICompanyWage
{
    private string companyName;
    private int maxWorkDays;
    private int maxWorkHours;
    private int hourlyPay;

    public WageManager(string companyName, int maxWorkDays, int maxWorkHours, int hourlyPay)
    {
        this.companyName = companyName;
        this.maxWorkDays = maxWorkDays;
        this.maxWorkHours = maxWorkHours;
        this.hourlyPay = hourlyPay;
    }

    public int ComputeEarnings()
    {
        int accumulatedHours = 0;
        int totalSalary = 0;
        int dayCount = 0;

        Console.WriteLine($"\nProcessing wages for {companyName}\n");

        while (accumulatedHours < maxWorkHours && dayCount < maxWorkDays)
        {
            Console.Write("Enter today's work hours (Max 8): ");
            int dailyHours = Convert.ToInt32(Console.ReadLine());

            if (dailyHours < 0 || dailyHours > 8)
            {
                Console.WriteLine("Invalid input. Enter a value between 0 and 8.");
                continue;
            }

            int dailyEarnings = dailyHours * hourlyPay;
            totalSalary += dailyEarnings;
            accumulatedHours += dailyHours;
            dayCount++;

            Console.WriteLine($"Day {dayCount}: Worked {dailyHours} hours, Earned Rs{dailyEarnings}/-, Cumulative Wage: Rs{totalSalary}/-");
        }

        Console.WriteLine($"\nWork Limit Reached for {companyName}!");
        Console.WriteLine($"Total Days Worked: {dayCount}, Total Hours Worked: {accumulatedHours}, Total Monthly Wage: Rs {totalSalary}/-");

        return totalSalary;
    }

    public string GetCompanyName()
    {
        return companyName;
    }
}