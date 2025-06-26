using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int n=int.Parse(Console.ReadLine());
      int i=1;
       while(i<n)
       {
           Console.WriteLine(i);
           i++;
       }
    }
}