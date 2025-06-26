// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

    using System;

    public class HelloWorld
    {
        public static void Main(string[] args)
        {
        int n=int.Parse(Console.ReadLine());
        Console.WriteLine(Fib(n));
        }
        static int Fib(int n)
        { if(n<=1)
        {
            return n;
        }
            int last=Fib(n-1);
            int Slast=Fib(n-2);
            return last+Slast;
        }
    }





    using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a=10;
        int b=0;int c=1;
        int ans=0;
        Fib(a,b,c,ans);
    }
    static void Fib(int a,int b,int c,int ans)
    {
        if(c>a)
        {
            return;
        }
        ans =b+c;
        // b=c;
        // c=ans;
        Console.WriteLine(c);
        Fib(a,c,ans,ans);//here keep in mind this step
        
        
        
    }
}