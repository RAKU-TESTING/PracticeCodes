// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public double real{get;set;}//property assign
    public double imaginary{get;set;}//property assign
    
    public HelloWorld(double Real,double Imaginary)//Constructor to Initialize Properties
    {
        real =Real;
        imaginary=Imaginary;
        
    }
    public static HelloWorld operator +(HelloWorld h1,HelloWorld h2)//operator Overloading
    {
        return new  HelloWorld (h1.real+h2.real,h1.imaginary+h2.imaginary);//here to initialize Constructor we used new Keyword
    }
    public static HelloWorld operator -(HelloWorld h1,HelloWorld h2)
    {
        return  new HelloWorld (h1.real-h2.real,h1.imaginary-h2.imaginary);
    }
    public override string ToString()// object class Methods to get value with i
    {
        return $"{real} + {imaginary}i";
    }
}
class Hello
{
    public static void Main(string[] args)
    { 
        HelloWorld h1=new HelloWorld(5,8);
        HelloWorld h2=new HelloWorld(2,9);
        Console.WriteLine($"h1={h1.real}+{h1.imaginary}i");
        Console.WriteLine($"h2={h2.real}+{h2.imaginary}i");
        Console.WriteLine($"Addition is ={h1+h2}");
        Console.WriteLine($"Substraction is={h1-h2}");
     
        
    }}
    