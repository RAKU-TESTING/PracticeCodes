// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string a="srk";
        char[] b=a.ToCharArray();
        int n=b.Length;
        int i=0;
        Reverse(ref b,i,n);
        foreach(var c in b)
        {
            Console.WriteLine(c);
        }
    }
    static void Reverse(ref char[]b,int i,int n)
    { 
        if(i>=n/2)
      {
        return ;
      }
       
        Swap(ref b[i],ref b[n-i-1]);
         Reverse(ref b,i+1,n);
        
    }
    static void Swap(ref char a,ref char b)
    {
        char c=a;
        a=b;
        b=c;
    }
    
}