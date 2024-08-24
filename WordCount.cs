
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       string []a={"Aarohi","Simran","Jassi","Puja","Aarohi","Jassi","Kaur"};
       Dictionary<string,int> b=new Dictionary<string,int>();
       for (int i=0;i<a.Length;i++)
       {
         if(b.ContainsKey(a[i]))
         {
             b[a[i]]++;
        }
        else
        {
            b[a[i]]=1;  
        }
    }
    foreach(var c in b)
    {
        Console.WriteLine(c.Key+"-"+c.Value);
    }
}}