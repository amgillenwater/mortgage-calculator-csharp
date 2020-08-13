using System;

namespace MortgageCalculator
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("What is the cost of your dream home (do not use commas, decimals or $ sign)?");
            string cost = Console.ReadLine();
            int costOfHome = Convert.ToInt32(cost);

            Console.WriteLine("What is your annual salary (do not use commas, decimals or $ sign)?");
            string salaryFromUser = Console.ReadLine();
            int annualSalary = Convert.ToInt32(salaryFromUser);

            Console.WriteLine("What percentage of your paycheck would you like to save, written as a decimal?");
            string savingsFromUser = Console.ReadLine();
            double savingsRate = Convert.ToDouble(savingsFromUser);


            //Console.WriteLine(costOfHome);
            //Console.WriteLine(salaryFromUser);
            //Console.WriteLine(savingsRate);

            double interestRate = 0.04 / 12;
            double downPayment = 0.25 * costOfHome;
            double monthlySalary = annualSalary / 12;
            double monthlySavings = monthlySalary * savingsRate;
            double currentSavings = 0;
            int months = 0;

            while (currentSavings < downPayment)
            {
                months += 1;
                currentSavings = currentSavings + (currentSavings * interestRate) + monthlySavings;
            }
            Console.WriteLine($"Number of months: {months}");
        }
    }
}
