// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    
    public virtual void H()
    {
        Console.WriteLine("parent");
    }
}
public class Hello:HelloWorld
{
    public static void Main(string[] args)
    {
       HelloWorld hh=new Hello();
       Hello h=new Hello();
       hh.H();
       h.HO();
       h.H();
       
    }
    public void HO(){
        Console.WriteLine("OKKKK");
    }
    public override void H()
    {
        Console.WriteLine("child");
    }
    
}