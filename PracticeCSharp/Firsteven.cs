using System;

class FirstEvenno
{
    public static void Run()
    {

        
        int[] a={2,45,66,7,9,3,55};
        bool isFind=false;

        for(int i=0;i<a.Length;i++)
        {
            if(a[i]%2==0)
            {
                isFind=true;
                Console.WriteLine(a[i]);
                break;
            }
        }
        if(!isFind)
        {
            Console.WriteLine("Even number not found");
        }
    }
}