using System;

class Stringpldrm
{
    public static void Run()
    {
        string str="malayalam";
        string reversed="";

        for(int i=str.Length-1;i>=0;i--)
        {
            reversed+=str[i];
        }
        if(str==reversed)
            Console.WriteLine("String is palindrome");
        else
            Console.WriteLine("String is not a palindrome");
        
    }
}