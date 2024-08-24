// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public HelloWorld(int a)
    {
   Console.WriteLine("This is HelloWorld Constructor");        
    }
  public HelloWorld()
  {
        Console.WriteLine("Oh My goodness");    
  }
    
}
public class Hello:HelloWorld
{    
    public Hello()
{
    Console.WriteLine("This is Hello Constructor");    
}
public Hello(string a)
{
    Console.WriteLine("This is Hello Constructor with string"); 
}
        public static void Main(string[] args)
    {
     //  Hello h =new Hello();
       HelloWorld ho=new Hello();
       
     //  Hello h2=new Hello("HII");
    }
}