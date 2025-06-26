// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={1,4,6,8,9,13};
        for(int i=0;i<a.Length-1;i++)
        {
            if((a[i+1]-a[i])>0)
            {
                while ((a[i]+1)<a[i+1])
                {
                    Console.WriteLine(a[i]+1);
                    a[i]++;
                }
            }
        }
        
    }
}           