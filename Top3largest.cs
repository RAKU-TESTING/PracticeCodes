
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={4,55,63,6,4,2,89,5};
        Array.Sort(a);
        string d=Console.ReadLine();
        int b=int.Parse(d);
        int c=(a.Length-b)-1;
       for(int i=a.Length-1;i>c;i--)
       {
           Console.WriteLine(a[i]);
       }
        
        
    }
}






// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    
    public static void Main(string[] args)
    {
        int [] b={999,2,77,11,3,6,5};
        for(int i=0;i<b.Length;i++)
        {
            for(int k=i;k<b.Length;k++)
            {
                if(b[i]>b[k])
                {
                Switch(ref b[i],ref b[k]) ;
                    
                }
            }
        }
         for(int j=b.Length-1;j>=0;j--)
    {
     Console.WriteLine("Top 3 Largest element are"+"="+b[j]);   
    }
        
    }
    public static void Switch(ref int a,ref int c )
    {
        int d=a;
        a=c;
        c=d;
    }
   
}


// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int[] a={4,5,63,6,4,2,89};
       ThirdLargest(a);
    }
    public static void ThirdLargest(int []a)
    {   int min=a[0];
    int max=0;
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]>min)
            {
              max=a[i];  
            }
        }
        Console.WriteLine(max);
        int secondmax=0;
        for(int i=0;i<a.Length;i++)
        {
          if(a[i]>secondmax && a[i]<max)
          {
              secondmax=a[i];
          }
        }
        Console.WriteLine(secondmax);
        int thirdmax=0;
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]<secondmax && a[i]>thirdmax)
            {
              thirdmax=a[i];  
            }
        }
        Console.WriteLine(thirdmax);
        
    }
}