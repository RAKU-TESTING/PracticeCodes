// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={3, 4, 4, 7, 8, 10};
        int x=5;
      Console.WriteLine(Floor(a,x));//floor means less Than or Equal to x;
      Console.WriteLine(Ceil(a,x));// Ceil Means grater than equal to x;
    }
    static int Floor(int[] a,int x)
    {
        int l=0;int h=a.Length-1;
        int ans=a.Length;
        while(l<=h)
        {
          int  mid=(l+h)/2;
            if(a[mid]<=x)///Here floor is this conditon
            {
                ans=a[mid];
                l=mid+1;
            }
            else
            {
                h=mid-1;
            }
        }
        return ans;
    }
    static int Ceil(int[] a,int x)
    {
        int l=0;int h=a.Length-1;
        int ans=a.Length;
        while(l<=h)
        {
          int  mid=(l+h)/2;
            if(a[mid]>=x)///Here Ceil is same as Lowest bound;
            {
                ans=a[mid];
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