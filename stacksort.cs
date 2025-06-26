// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Stack <int> a=new Stack<int>();
     a.Push(30);
     a.Push(-5);
     a.Push(18);
     a.Push(14);
     a.Push(-3);
    //  Show(a);
     SortedStack(a);
     Show(a);
     
     
    }
    static void Show(Stack<int> a)
    {
        foreach(var b in a)
        {
            Console.WriteLine(b);
        }
    }
    static void SortedStack(Stack<int> a)
    {
        if(a.Count==0)
        {
            return;
        }
        int x=a.Peek();
        a.Pop();
        SortedStack(a);
        
    }
    
}
    