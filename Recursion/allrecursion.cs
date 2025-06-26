using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string a="AbA";
       Console.WriteLine(Palingdrome(a,0,a.Length-1));
       
    }
    static bool Palingdrome(string a,int start,int end)
    {
        if(start>=end )
        {
            return true;
        }
        if(a[start]!=a[end])
        {
            return false;
        }
       
        
        return  Palingdrome(a,start+1,end-1);
        
    } 
    
}

using System;

public class HelloWorld
{ 
    
    public static void Main(string[] args)
    {
        int N=5;
        
       Console.WriteLine(SumN(N));
       Console.WriteLine(Factorial(N));
    }
    static int SumN(int N)
    {   
        if(N==1)
        {
            return 1 ;
        }
      return N+SumN(N-1);
      
    }
    static int Factorial(int N)
    {if(N==1)
        {
            return 1 ;
        }
      return N*Factorial(N-1);
        
    }
}
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int N = 5;
        // Console.WriteLine(SumN(N));
    Sum(5,0); 
    }

    static int SumN(int N)
    {
        if (N == 1)
            return 1;
        else
            return N + SumN(N - 1);
    }
    static void Sum(int i,int sum)
    {
        if(i<1)
        {
            Console.WriteLine(sum);
            return;
        }
        Sum(i-1,sum+i);
        
    }
}
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int count =0;
        int i=0;
        int n=4;
        int j=1;
        int N=11;
        int p=5;
        HelloWorld h=new HelloWorld();
        h.Print(count);
        h.Printname(i,n);
        // h.PrintNums(j,N);
        h.PrintReverse(j,N);
        Console.WriteLine(h.Sum(j,p));
        
    }
    void Print(int count)
    {
        if (count==3)
        {return;}
        count++;
         Console.WriteLine(count);
        Print(count);
       
    }
    void Printname(int i,int n)
    {
        if(i==n)
        {
            return;
        }
        Console.WriteLine("Rakesh");
        Printname(i+1,n);
    }
    void PrintNums(int j,int N)
    {
        if(j>N)
        {
            return;
        }
        Console.WriteLine(j);
        PrintNums(j+1,N);
        
    }
     void PrintReverse(int j,int N)
    {
        if(j>N)
        {
            return;
        }
       PrintReverse(j+1,N);
        Console.WriteLine(j);
        
    }
    int Sum(int j,int p)
    {
        if(j==1)
        {
            return ;
        }
        Sum(j,p);
        
    }
}
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    //   Console.WriteLine(Fibonacci(6));
       int a=0;int b=1;
        Console.WriteLine(a);
        Console.WriteLine(b);
       fin(6,a,b);
    }
    static int Fibonacci(int i)
    {
        if(i==0)
        {
            return 0;
        }
        if(i==1)
        {
            return 1;
        }
        
         
       return  Fibonacci(i-1)+Fibonacci(i-2);
    }
    static void fin(int n,int a,int b)
    {for(int i=2;i<n;i++)
    {
        int c=a+b;
        Console.WriteLine(c);
        a=b;
        b=c;
    }
}}