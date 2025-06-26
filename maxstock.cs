// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={7,6,4,3,1};//these are stock price of stock in week if you buy get the profit at max by selling that week
        int max=0;int final=0;int buy=0;int sell=0;
        for(int i=0;i<a.Length-1;i++)
        { max=0;
          for(int j=i+1;j<a.Length;j++)
           {
               if(a[j]>a[i])
               {
                   max=a[j]-a[i];
                   if(max>final)
                   {
                       final=max;
                       buy=i;
                       sell=j;
                   }
                   
               }
           }
        }
        
        Console.WriteLine(final);
        Console.WriteLine("buy"+"="+buy);
        Console.WriteLine("sell"+"="+sell);
        
    }
}