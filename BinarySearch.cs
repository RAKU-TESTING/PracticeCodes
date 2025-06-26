
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={1,3,9,2,4,7,12,5};
        Array.Sort(a);
        int mid=a[(a.Length/2)-1];
        
        int b=int.Parse(Console.ReadLine());
        if(b<=mid)
        {
        for(int i=0;i<mid+1;i++)
        {
            if(a[i]==b)
            {
                Console.WriteLine("Index of element is"+" "+i);
            }
        }}
        else
        {
            for(int i=mid;i<a.Length;i++)
        {
            if(a[i]==b)
            {
                Console.WriteLine("Index of element is"+" "+i);
            }
        }
            
        }
    }}
     



     using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={3,5,9,12,13,15,16};
        int target=8;
        int low=0;int high=a.Length-1;
        Console.WriteLine(Giveindex(a,low,high,target));
    }
    static int Giveindex(int[] a,int low,int high,int target)
    {
        if(low>high)
        {
            return -1;
        }
       int mid=(low+high)/2;
        if(a[mid]==target)
        {
            return mid;
        }
        else if(target>a[mid])
        {
            return Giveindex(a,mid+1,high,target);
        }
        return Giveindex(a,low,mid-1,target);
        
        
    }
}