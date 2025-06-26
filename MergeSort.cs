// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={3,1,2,4,1,5,2,6,4};
       int low=0;
        int high=a.Length-1;
        MergeSort(a,low,high);
        foreach (var b in a)
        {
            Console.WriteLine(b);
        }
       
    }
    public static void MergeSort(int[]a,int low,int high)
    {
        if(low>=high)
       {
        return;
       }
        int mid=(low+high)/2;
        MergeSort(a,low,mid);
        MergeSort(a,mid+1,high);
       Merge(a,low,mid,high);
       
    }
    public static void Merge(int[]a,int low,int mid,int high)
    {
        List<int> ar=new List<int>();
       int  left=low;
        int right=mid+1;
        while(left<=mid && right<=high)
    {
        if(a[left]<=a[right])
        {
            ar.Add(a[left]);
            left++;
        }
        else
        {
            ar.Add(a[right]);
            right++;
            rr
        }
    }
    while(left<=mid)
    {
        
        
            ar.Add(a[left]);
            left++;
        
    }
    while( right<=high)
    {
         ar.Add(a[right]);
            right++;
    }
     for(int i=low;i<=high;i++)
        {
            a[i]=ar[i-low];
        }
    }
    
}
