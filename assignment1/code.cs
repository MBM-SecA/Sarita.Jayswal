using System;

class Program
{
    static void Main()
    {
        //write C# method that returns true if sum of both numbers is greater than 500. Otherwise returns false.
        Console.WriteLine("Check Sums:");

        BothSum bothSum = new BothSum();

        Console.WriteLine("Please enter the 1st number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the 2nd number");
        int num2 = int.Parse(Console.ReadLine());

        bool result = bothSum.sum(num1, num2);
        Console.WriteLine($"Your sum is {result}.");

        // calculates the number of points a football team has obtained so far. Rule - wins get 5 points, draws get 2 point and losses get 0 points.
        Console.WriteLine();
        Console.WriteLine("Check win-lose status");

        WinLosecalculator winLosecalculator = new WinLosecalculator();

        Console.Write("Enter the number of wins:");
        int win = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of draws:");
        int draw = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of loss:");
        int loss = int.Parse(Console.ReadLine());

        int calculatedpoints = winLosecalculator.Numbers(win, draw, loss);
        Console.WriteLine($"The total point of your team is {calculatedpoints}");


        //Question-3
        Console.WriteLine();
        Console.WriteLine("Check Initials of your name");

        StringInitials stringInitials = new StringInitials();

        Console.Write("Enter Your Full Name::");
        string input = Console.ReadLine();


        string Initials = stringInitials.Initials(input);
        Console.WriteLine($"Your name Initials is:: {Initials}");
    }
}