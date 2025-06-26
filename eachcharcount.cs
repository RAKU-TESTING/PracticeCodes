// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{      int c=0;
    public static void Main(string[] args)
    {
        HelloWorld h=new HelloWorld(); 
      string a="Welcome HelloWorld";
    
    //string [] b=a.Split(' ');
    for (int i=0;i<a.Length;i++)
{
        if(a[i]!=' ')
    {
        h.c++;
    }
}
Console.WriteLine(h.c);
}
}