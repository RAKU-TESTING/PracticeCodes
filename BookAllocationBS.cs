using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={12, 34, 67, 90};
        int m=2;
       Console.WriteLine(BookAllocation(a,m));
    }
    static int BookAllocation(int []a,int m)
    {
        int l=Max(a);
        // Console.WriteLine(l);
        int h=Sum(a);
        // Console.WriteLine(h);
        int mid=0;int ans=0;
        while(l<=h)
        {
            mid=(l+h)/2;
            int countstudent=Check(a,m,mid);
            if(countstudent>m)
            {
                l=mid+1;
            }
            else
            {
                h=mid-1;
            }
        }
        return l;
    }
    static int Check(int[]a,int m,int mid)
    {
        int sum=0;int count=1;
        for(int i=0;i<a.Length;i++)
        {
           
            if(sum+a[i]<=mid)
            {
            sum=sum+a[i];
            }
            else
            {
                count++;
                sum=a[i];
            }
            
        }
      return count;
        
    }
    static int Max(int []a)
    {
        int max=int.MinValue;
       
        for(int i=0;i<a.Length;i++)
        {
           
            if(a[i]>max)
            {
                max=a[i];
            }
        }
       
        return max;
       
    }
   
    static int Sum(int []a)
    {
        int sum=0;
       
        for(int i=0;i<a.Length;i++)
        {
           sum=a[i]+sum;
        }
       
        return sum;
    }
   
   
}