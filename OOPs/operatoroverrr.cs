// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
using System;
public class Hello
{
 public int A{get;set;}
 public int B{get;set;}
 public Hello(int a,int b)
 {
     A=a;B=b;
     
 }
 public static Hello operator +(Hello p,Hello q)
 {
   Hello hh=new Hello(p.A+q.A,p.B+q.B);
   return hh;
    //  return new Hello(p.A+q.A,p.B+q.B);
 }
 public static Hello operator -(Hello p,Hello q)
 {
  return new Hello(p.A-q.A,p.B-q.B);  
 }
    //  public override string ToString()
    // {
    //     return $"Hello(A: {A}, B: {B})";
    // }
}
public class Program
{ 
    public static void Main(string[] args)
    {
         Hello h=new Hello(10,12);
        //  h.A=10;h.B=12;
         Hello h1=new Hello(4,6);
        //  h1.A=4;h1.B=6;
        //  Hello h2=new Hello();
         Hello h2=h+h1;
         Hello h3=h-h1;
         Console.WriteLine(h2);
         Console.WriteLine(h3);
    }
    
    
}
 
