
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

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
        HelloWorld hw =new Hello();
        // Hello h =new Hello();  
         //h.Huuu(12);
         //h.H();
         hw.Huuu(10);//here it is very important point always remember when you Make parent reference with 
         //child class instance it will not called pure Child Class but when We do method shadowing the method 
         //in child Class become pure child class Method so we can Called it. 
     
    }
    public void HO(){
        Console.WriteLine("OKKKK");
    }
    public override void H()
    {
        Console.WriteLine("child");
    }
    public new void Huuu(int i)
    {
          Console.WriteLine("HUUUU with i //method Shadowing"); //method hiding
    }
    
    
    
}