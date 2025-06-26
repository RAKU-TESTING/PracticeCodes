// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      string a="a";
      string b="s";
      int c= b.CompareTo(a);
      if (c==0)
      {
          Console.WriteLine("it is equal");
      }
      else if(c<0)
      {
          Console.WriteLine("b is first");
      }
      else 
      {
          Console.WriteLine("a is first");
      }
      
    }
}