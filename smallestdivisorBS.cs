// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      
         int [] a={8,4,2,3};//  3
         int limit=10;
    Console.WriteLine(SmallestDivisor(a,limit));
        
    }
    static int SmallestDivisor(int []a,int limit)
    {
        int l=1;int h=Findmax(a);int ans=-1;
        while(l<=h)
        {
        int mid=(l+h)/2;
            int midN=CheckDivisor(a,mid);
            if(midN<=limit)
            {ans=mid;}
            if(midN>limit)
            {
                l=mid+1;
            }
            else
            {
                h=mid-1;
            }
        }
        return ans;
    }
     static int CheckDivisor(int []a,int mid)
    {int count=0;int index=0;
        while( index<a.Length)
        {
           count+=(int)Math.Ceiling((double)a[index]/mid);
           index++;
        }
        
        return count;
    }
    static int Findmax(int []a)
    {int max=int.MinValue;
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]>max)
            {
                max=a[i];
            }
        }
        return max;
    }
}