using System;

class Fibo
{
    public static void Run()
    {
        int n1=0,n2=1,n3=0;
        int limit=10;
        Console.WriteLine(n1);
        Console.WriteLine(n2);

        for(int i=2;i<limit;i++)
        {
            n3=n1+n2;
            Console.WriteLine(n3);
            n1=n2;
            n2=n3;
        }
        
    }
}