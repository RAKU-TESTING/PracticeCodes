// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   int a=10;int b=10; 
        int max=((a+b)+Math.Abs(a-b))/2;
         int min=((a+b)-Math.Abs(a-b))/2;
        Console.WriteLine (max +" "+"is maximum number");
    }
}