// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       List<char>d=new List<char>{'a','b','c','c','c'};
       char[] e=d.ToArray();//for collection toArray
        string a="srkkk";
        char[] b=a.ToCharArray();//for string Tochararray();
        foreach (var c in b)
        {
            Console.WriteLine(c);
        }
    }
}