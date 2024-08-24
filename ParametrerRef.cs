// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int myNumber = 5;
DoubleValue(ref myNumber);
Console.WriteLine(myNumber);
    }
     static void DoubleValue(ref int number) {
    number *= 2;
    
}


}