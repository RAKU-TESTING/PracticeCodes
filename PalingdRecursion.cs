// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       string a="atggrta";
       int r=a.Length-1;
       int l=0;
       if(Pal(a,r,l))
       {Console.WriteLine("it is");}
       else
       {
           Console.WriteLine("it not");
       }
    }
    static bool Pal(string a,int r,int l)
    { if(l>=r)
      {
        return true;
      }
        if(a[l]!=a[r])
        {
            return false;
        }
        
        return Pal(a,r-1,l+1);
    }
}