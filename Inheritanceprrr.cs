// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
 { 
    //  private HelloWorld(int a)

// {
//     Console.WriteLine("Parent Constructor"+a);
// }
    public  void Test1()
    {
        Console.WriteLine("Parent Method");
    }
}
public class Hello:HelloWorld
{
    // public Hello(int a) : base(a)
    // {
    // }

    public void Test2()
    {
        Console.WriteLine("Child Method");
    }
     public static void Main(string []args)
    {
        Hello h=new Hello();
        h.Test1();
        h.Test2();
        HelloWorld h1=new Hello();
        h1.Test2();
        
        // h.Test1();
        // h.Test2();
        
    }
}