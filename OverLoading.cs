// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    
    public virtual void H()
    {
        Console.WriteLine("parent");
    }
    public void Huuu(int i)
    {
        Console.WriteLine("HUUUU with i"); 
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
       hh.Huuu(10);
      // h.Huuu("sss");
     Huuu("sss");
    }
    public void HO(){
        Console.WriteLine("OKKKK");
    }
    public override void H()
    {
        Console.WriteLine("child");
    }
    public static void Huuu(string s)
    {
        Console.WriteLine ("HOOOOO string s");
    }
    
}