// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int []a={1,2,3,4,5,6,7};
        int k=5;
        Rightadd(a,k);
        foreach(var b in a)
        {
        Console.WriteLine(b);    
        }
    }
    public static void Rightadd(int []a,int k)
    {
    int [] temp=new int[k];
    int o=0;
    for(int i=a.Length-k;i<a.Length;i++)
    {
        temp[o]=a[i];
        o++;
    }
    for(int i=a.Length-1;i>=k;i--)
    {
        a[i]=a[i-k];
    }
   
    
    for (int l=0;l<k;l++)
    {
        a[l]=temp[l];
        
    }
    }
}