
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={4,5,6,7,0,1,2,3};
        int target=11;
        Console.WriteLine(SearchElement(a,target));
        
    }
    static int SearchElement(int []a,int target)
    {
        int l=0;int h=a.Length-1;int ans=-1;
        int mid=(l+h)/2;
        if(a[mid]==target)
        {
           return mid;
        }
        if(target>a[mid] || target<=a[h])
        {
            l=mid+1;
            // Console.WriteLine("right");
        }
        else
        {
            h =mid-1;
            // Console.WriteLine("Left");
        }
        while(l<=h)
        {
            mid=(l+h)/2;
            if(a[mid]>=target)
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