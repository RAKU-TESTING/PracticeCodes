// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] a={"sunday","monday","tuesday","wednesday","Thursday","friday","Saturday"};
         string b=Console.ReadLine();
            char c=b[0];
        for(int i=0;i<a.Length;i++)
        { 
           
            string d=a[i];
            char e=d[0];
             if(c==e)
             {
                 Console.WriteLine("today is"+" "+a[i]);
                 break;
               }
            
        }
}}