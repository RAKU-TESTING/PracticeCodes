// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int [] arr={6,2,3,4,7,2,1,7,1};
        int a=Yess(arr,4);
        Console.WriteLine(a);   
    }
    
    public static int Yess(int[] arr,int k)
    {
        int lsum=0;int rsum=0;int maxsum =0;
        for(int i=0;i<k;i++)
        {
            lsum=lsum+arr[i];
            maxsum=lsum;
        }
        int rindex=arr.Length-1;
        for(int i=k-1;i>=0;i--)
        {
            lsum=lsum-arr[i];
            rsum=rsum+arr[rindex];
            rindex=rindex-1;
            maxsum=Math.Max(maxsum,lsum+rsum);
            
        }
        return maxsum;
       }
}