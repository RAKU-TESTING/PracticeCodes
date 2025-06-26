// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public class BaseClass
{
    public BaseClass(int x)
    {
        Console.WriteLine("Base class constructor called with value: " + x);
    }
}

public class DerivedClass : BaseClass
{
    public DerivedClass(int x, int y) : base(x) // Calling the base class constructor
    {
        Console.WriteLine("Derived class constructor called with value: " + y);
    }
}
public class hello
{
public static void Main(string[]args)
{
       DerivedClass d=new DerivedClass(10,20);
      
}
}