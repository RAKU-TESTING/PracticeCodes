// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={1,2,3,3,5,8,8,10,10,11};//lower bound means if that value is present return 
                                //    index or return the index which value is greater than x   i.e a[index]>=x
                                //also known as search insert operation
        int x=4;
      Console.WriteLine(LowestBound(a,x));
    }
    static int LowestBound(int[] a,int x)
    {
        int l=0;int h=a.Length-1;
        int ans=a.Length;
        while(l<=h)
        {
          int  mid=(l+h)/2;
            if(a[mid]>=x)
            {
                ans=mid;
                h=mid-1;
            }
            else
            {
                l=mid+1;
            }
        }
        return ans;
    }
}