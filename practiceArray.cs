// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={2,5,5,17,9,12};
        int max=a[0];
        Console.WriteLine(Largest(a,max));
        Console.WriteLine(SecondLargest(a,max));
        Console.WriteLine(CheckSorted(a));
    }
    static int Largest(int[]a,int max)
    { 
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]>max)
            {
                max=a[i];
            }
            
        }
        return max;
    }
     static int SecondLargest(int[]a,int max)
    { int SecondMax=0;int smallest=a[0];int secSmall=int.MaxValue;
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]>max)
            {  SecondMax=max;
                max=a[i];
            }
            if(a[i]>SecondMax && a[i]<max)
            {
                SecondMax=a[i];
            }
            if(a[i]<smallest)
            {  secSmall=smallest;
                smallest=a[i];
                
            }
            if(a[i]<secSmall && a[i]>smallest)
            {
                secSmall=a[i];
            }
            
            
        }
         Console.WriteLine("smallest is-"+smallest);
        Console.WriteLine("secSmall is-"+secSmall);
        return SecondMax;
    }
    static bool CheckSorted(int []a)
    { int b=0; 
        if(a.Length>1)
        {
          if(a[0]<a[1])
          {
              b=1;
          }    
        
        
            for(int i=0;i<a.Length-1;i++)
            { 
                if(b==1)
                {
                     if(a[i+1]<a[i])
                   {
                    return false;
                   }
                }
                if(b==0)
                {
                    if(a[i]<a[i+1])
                    {
                        return false;
                    }
                }
            }
        
        }
        return true;
    }
    
}