// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = {1,1,1,1,0,1,0,1,1,1};
        Countone(a);
        
    }
    static void Countone(int[]a)
    {
      int r=0;int length=0;int maxlength=0;
        while(r<a.Length)
        {
            if(a[r]==1 )
            {
                length++;
                if(length>maxlength)
                {
                maxlength=length;    
                }
            }
            else{length=0;
               while(a[r]==1)
               {
                   r++;
               }
            }
            r++;
        }
        Console.WriteLine(maxlength);
    }
}