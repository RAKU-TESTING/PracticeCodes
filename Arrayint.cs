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
    string a=Console.ReadLine();
    b[i]=int.Parse(a);
    c[i]=0-int.Parse(a);
    d[i]=2*int.Parse(a);    
    }
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