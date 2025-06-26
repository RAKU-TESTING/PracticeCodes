
using System;
public delegate int MyDelegate(int num);
public class HelloWorld
{
    public static void Main(string[] args)
    {
        MyDelegate obj=a=>a+=5;
        Console.WriteLine(obj(5));
    
        
    }
}