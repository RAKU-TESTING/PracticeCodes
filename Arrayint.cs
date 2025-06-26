// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        int [] b =new int[5];
        int [] c =new int [5];
        int [] d =new int [5];
   for(int i=0;i<5;i++)
    {
    Console.WriteLine("Enter the Number");
    string a=Console.ReadLine();
    int num;
    if(int.TryParse(a,out num))
    {b[i]=num;
    c[i]=-num;
    d[i]=2*num;    
    }
    else{
        Console.WriteLine("please Enter valid input");
        i--;
    }}
    Console.WriteLine("Negative Array is:");
   for(int i=0;i<b.Length;i++)
   {
        Console.WriteLine(c[i]);
    }
    Console.WriteLine("Double Array is:");
    for(int i=0;i<b.Length;i++)
   {
        Console.WriteLine(d[i]);
    }
       
    }}