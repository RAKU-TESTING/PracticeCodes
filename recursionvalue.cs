// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{ static int ans=11;
    public static void Main(string[] args)
    {Console.WriteLine("enter the value");
        long a=11;
        string b="";
        long e=a;
        
        // while(a>0)
        // {int lastdigit=a%10;
        //  b=b+lastdigit.ToString();
        //  a=a/10;
        // }
        
    long c=11;
    // Console.WriteLine(e);
    long d=Value(e,c);
    // Console.WriteLine(c);
    Console.WriteLine(d);
        
        
    }
    public static long Value(long a,long c)
    {
        if(c==0)
        {
            return 1;
        }
        // if(a==0){return 1;}
        // Console.WriteLine(Value(a,c-1));
    //  long ans=(long)(a * Value(a,c-1));
    return a * Value(a,c-1);
    
        
    }
}