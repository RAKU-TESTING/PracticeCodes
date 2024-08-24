

Skip to content
Using Gmail with screen readers
Enable desktop notifications for Gmail.   OK  No thanks
Conversations
3.5 GB of 15 GB used
Terms · Privacy · Program Policies
Last account activity: 13 hours ago
Details

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Complex
{
    public int Real{get;set;}
    public int Imaginary{get;set;}
    public Complex(int real,int imaginary)
    {
        Real=real;Imaginary=imaginary;
    }
public static Complex operator +(Complex a,Complex b)
{
    Complex c=new Complex(a.Real+b.Real,a.Imaginary+b.Imaginary);
    return c;
}
public static Complex operator -(Complex a,Complex b)
{
    Complex c=new Complex(a.Real-b.Real,a.Imaginary-b.Imaginary);
    return c;
}
public static Complex operator *(Complex a,Complex b)
{
    Complex c=new Complex(a.Real*b.Real,a.Imaginary*b.Imaginary);
    return c;
}
public static Complex operator /(Complex a,Complex b)
{
    Complex c=new Complex(a.Real/b.Real,a.Imaginary/b.Imaginary);
    return c;
}
public  override string ToString()
{
    return $"{Real}+{Imaginary}i";
}}
class Program
{
    public static void Main(string [] args)
    {
        Complex c1=new Complex(1,5);
        Complex c2=new Complex(2,3);
        Complex c3=c1+c2;
        Complex c4=c1-c2;
        Complex c5=c1*c2;
        Complex c6=c1/c2;
        Console.WriteLine(c3); Console.WriteLine(c4);
         Console.WriteLine(c5); Console.WriteLine(c6);
        
        
    }
    
}

OPERATORoVERLOADING.txt
Displaying OPERATORoVERLOADING.txt.