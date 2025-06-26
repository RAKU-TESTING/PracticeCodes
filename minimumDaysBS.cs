// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // int [] a={7,7,7,7,13,11,12,7};//minimum days require  to make bouqet from Roses where at least
         int [] a={1, 10, 3, 10, 2};                                   //  3 roses required in single bouqet  and 2 bouqet should made but remember rose should be adjacent 
                                            // here ans is on 12th day -first bouqet on 7 th day (from first four adjacent)and another on 12th day(last 3 adjacent);   
         int m=2;int k=3;
        int o=m*k;
        if (a.Length<o)
        {
            Console.WriteLine("-1");
        }
        else
        {
        Console.WriteLine(MinimumDays(a,o));
        }
    }
    static int MinimumDays(int []a,int o)
    {
        int l=0;int h=Findmax(a);
        while(l<=h)
        {
        int mid=(l+h)/2;
            int midN=CheckRoses(a,o,mid);
            if(midN==o)
            {return mid;}
            if(midN<o)
            {
                l=mid+1;
            }
            else
            {
                h=mid-1;
            }
        }
        return -1;
    }
    static int CheckRoses(int []a,int o,int mid)
    {int count=0;
        for(int i=0;i<a.Length-1;i++)
        {
            if(a[i]<=mid && (a[i+1]<=mid || a[i-1]<=mid))
            {
                count++;
            }
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