// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int []a={1,0,2,3,0,4,0,1};
       Arrange(a);
       foreach (var b in a)
         {
             Console.WriteLine(b);
         }
    }
    static void Arrange(int [] a)
    {
        int l=0;
        int r=1;
        while(r<a.Length)
        {
            if(a[l]!=0)
            {l++;}
            else if(a[r]!=0)
            { 
              
                 int temp=a[l];
                 a[l]=a[r];
                 a[r]=temp;
               l++;
                 
               }
               r++;
             }
            
            
         }
         
        
    }