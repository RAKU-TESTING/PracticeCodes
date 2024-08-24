
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={4,55,63,6,4,2,89,5};
        Array.Sort(a);
        string d=Console.ReadLine();
        int b=int.Parse(d);
        int c=(a.Length-b)-1;
       for(int i=a.Length-1;i>c;i--)
       {
           Console.WriteLine(a[i]);
       }
        
        
    }
}