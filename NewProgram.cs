// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={5,4,5,2,3,4,5,6};
        int n=9;
        Console.WriteLine(CheckDivisor(a,n));
    }
     static int CheckDivisor(int []a,int n)
    {
        int sum=0;int l=0;int r=0;int count=0;int day=0;int now=0;
       while(r<a.Length)
       {sum=sum+a[r];
        //  Console.WriteLine(sum); 
         while(sum>n)
         {
             now++;
             sum=sum-a[r];
             l=r;
             if(sum<=n)
             {
                 day++;
             }
             
         }
         
        //  count=count+(r-l+1);
         r++; 
        }
        
        return now;
    }
}