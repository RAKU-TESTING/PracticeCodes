// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
using System;
public class HelloWorld
{
public static void Main(string []args)
{  
    int[] a={5,4,5,2,3,4,5,6};
    int target=8;
    Console.WriteLine(CalculateDays(a,target));
}
    static int CalculateDays(int[] a,int target)
    {
        int l=0;int r=0; int sum=0;int count=0;             
        while(r<a.Length)
        {
            if(a[r]<=target)
            {
            sum=sum+a[r];
               
            }
            if(sum==target)
            {
                count++;
               
                sum=0;
            }
            else if(sum>target)
            {
                sum=sum-a[r];
                count++;
            //   Console.WriteLine(count);
               sum=a[r];
               if(r==a.Length-1 && a[r]<=target)
               {
                   count++;
               }
            }
            else if(r==a.Length-1 && a[r]<=target)
                {
                    // Console.WriteLine(r);
                    count++;
                }
               
                r++;
               
            }
        return count;
    }}