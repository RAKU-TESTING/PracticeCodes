// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={-2,1,-3,4,-1,2,1,-5,4};
        int maxsum=0;int start=0;int end=0;
        for(int i=0;i<a.Length-1;i++)
        { 
            int sum=a[i];
           for(int j=i+1;j<a.Length;j++)
           {
               sum=sum+a[j];
               if(maxsum<sum)
               {
                   maxsum=sum;
                   start=i;
                   end=j;
               }
           }
        }
        Console.WriteLine(maxsum);
        Console.WriteLine("start"+"="+start);
        Console.WriteLine("end"+"="+end);
        
    }
}