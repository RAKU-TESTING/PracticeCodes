
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int x=int.Parse(Console.ReadLine());
        int i=1;int j=1;
        
        while (i<=x)
        {
            j=j*i;
            i++;
        }
        Console.WriteLine(j);
    }
}