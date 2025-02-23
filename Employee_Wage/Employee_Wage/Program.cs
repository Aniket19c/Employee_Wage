using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            CompanyWage reliance = new CompanyWage("Reliance", 22, 160, 20);
            CompanyWage dmart = new CompanyWage("DMart", 22, 160, 20);

            int relianceSalary = reliance.ComputeCompanySalary();
            int dmartSalary = dmart.ComputeCompanySalary();

            int combinedWages = relianceSalary + dmartSalary;

            Console.WriteLine("\n========== FINAL WAGE REPORT ==========");
            Console.WriteLine($"Total wage for Reliance: Rs {relianceSalary}/-");
            Console.WriteLine($"Total wage for DMart: Rs {dmartSalary}/-");
            Console.WriteLine($"Aggregate wage for all companies: Rs {combinedWages}/-");
        }
    }
}

public class CompanyWage
{
    private string companyName;
    private int workDays;
    private int maxMonthlyHours;
    private int hourlyRate;

    public CompanyWage(string companyName, int workDays, int maxMonthlyHours, int hourlyRate)
    {
        this.companyName = companyName;
        this.workDays = workDays;
        this.maxMonthlyHours = maxMonthlyHours;
        this.hourlyRate = hourlyRate;
    }

    public int ComputeCompanySalary()
    {
        int salaryTotal = 0;
        int accumulatedHours = 0;
        int daysCount = 0;

        Console.WriteLine($"\nProcessing wages for {companyName}\n");

        while (accumulatedHours < maxMonthlyHours && daysCount < workDays)
        {
            Console.Write("Enter hours worked today (Max 8): ");
            int workHours = Convert.ToInt32(Console.ReadLine());

            if (workHours < 0 || workHours > 8)
            {
                Console.WriteLine("Invalid entry. Enter a value between 0 and 8.");
                continue;
            }

            int dailyEarnings = workHours * hourlyRate;
            salaryTotal += dailyEarnings;
            accumulatedHours += workHours;
            daysCount++;

            Console.WriteLine($"Day {daysCount}: Worked {workHours} hours, Earned: Rs {dailyEarnings}/-, Cumulative Wage: Rs {salaryTotal}/-");
        }

        Console.WriteLine($"\nWork Limit Reached for {companyName}!");
        Console.WriteLine($"Total Days Worked: {daysCount}, Total Hours Worked: {accumulatedHours}, Monthly Wage for {companyName}: Rs {salaryTotal}/-");

        return salaryTotal;
    }
}
