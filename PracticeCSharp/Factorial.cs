using System;

class Factorial
{
    public static void Run()
    {
        int n=5;
        int fact=1;

        for(int i=1;i<=n;i++)
        {
            fact*=i;
        }
        Console.WriteLine($"Factorial of {n} is {fact}");
    }
}