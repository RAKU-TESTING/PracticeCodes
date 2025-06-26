using System;

class RDCalculator
{
    static void Main(string[] args)
    {
        double monthlyInstallment = 500; // P
        double annualInterestRate = 6; // r as a percentage
        int numberOfYears = 1/12; // t

        double maturityAmount = CalculateRDMaturity(monthlyInstallment, annualInterestRate, numberOfYears);
        Console.WriteLine($"The maturity amount is: {maturityAmount:F2}");
    }

    static double CalculateRDMaturity(double P, double r, int t)
    {
        double R = r / 100;
        int n = 1; // Yearly compounding
        int totalMonths = t * 12;
        double maturityAmount = 0;

        for (int i = 0; i < totalMonths; i++)
        {
            double timeRemaining = (totalMonths - i) / 12.0;
            maturityAmount += P * Math.Pow(1 + R / n, n * timeRemaining);
        }

        return maturityAmount;
    }
}
