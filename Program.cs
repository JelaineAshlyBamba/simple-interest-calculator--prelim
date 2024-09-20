using System;

class Program
{
    static void Main(string[] args)
    {
        // Input values
        Console.Write("Enter the principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the rate of interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Simple Interest formula: SI = (P * R * T) / 100
        double simpleInterest = (principal * rate * time) / 100;

        // Output the result
        Console.WriteLine("The Simple Interest is: " + simpleInterest);
    }
}
