using System;

class Stringrev
{
    public static void Run()
    {
        string str="Hello World";
        string Reversed="";

        for(int i=str.Length-1;i>=0;i--)
        {
            Reversed+=str[i];
        }
        Console.WriteLine("Reverse of a string:"+Reversed);
    }
}