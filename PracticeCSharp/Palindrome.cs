using System;

class Palindrome
{
    public static void Run ()
    {
        int n=121;
        int rev=0,rem=0;
        int num=n;

        while(n!=0)
        {
            rem=n%10;
            rev=rev*10+rem;
            n=n/10;

        }
        if(rev==num)
        {
            Console.WriteLine("Number palindrome");
        }
        else
        {
            Console.WriteLine("Number is palindrome");
        }
    }
}