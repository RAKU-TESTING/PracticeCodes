// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
     static bool Check(int a, int b)
    {
   return (a^b)==0;
    }
    static void Main(string [] args)
    {
        if(Check(5,5))
        {
            Console.WriteLine("Equal");
        }
        else
        {
           Console.WriteLine("Not Equal"); 
        }
    }
}