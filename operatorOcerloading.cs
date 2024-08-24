
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{ 
    public int Value{get;set;}
    
    public HelloWorld(int value)
    {
     Value=value;        
    }
    public static bool operator >(HelloWorld h1,HelloWorld h2)
    {
        return h1.Value>h2.Value;
    }
    public static bool operator <(HelloWorld h1,HelloWorld h2)
    {
        return h1.Value<h2.Value;
    }
    public static int operator -(HelloWorld h1,HelloWorld h2)
    {
        return h1.Value-h2.Value; 
    }
    
    
}
class Hello
{ 
    public static void Main(string []args)
    {
        HelloWorld h1=new HelloWorld(12);
       HelloWorld h2=new HelloWorld(10);
        Console.WriteLine(h1-h2);
       if(h1<h2)
       {
           Console.WriteLine("true");
       }
       else
       {
    Console.WriteLine("False");
       }
    
    
}}
