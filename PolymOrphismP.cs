// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Parent
{
    public virtual void Test()
    {
        Console.WriteLine ("I am for Override from Parent");
    }
    public void Test2()
    {
        Console.WriteLine ("I am for Hiding from Parent");
    }
}
public class Child:Parent
{
     public override void Test()
    {
        Console.WriteLine ("I am for Override from Child");
        base.Test();
    }
    public  new void Test2()
    {
        Console.WriteLine ("I am for Hiding from Child");
        base.Test2();
    }
    public static void Main(string[] args)
    {
        Child c=new Child();
        c.Test();
        c.Test2();
        Console.WriteLine("\n");
        Parent p=new Child();
        p.Test();
        p.Test2();
         Console.WriteLine("\n");
        Parent pp=new Parent();
        pp.Test();
        pp.Test2();
    }
}