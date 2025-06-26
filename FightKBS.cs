// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

    using System;

    public class HelloWorld
    {
        public static void Main(string[] args)
        {
        int[] a={4,7,9,10};
        int k=3;
        Console.WriteLine(FindK(a,k));//Here We have to find missing number at Kth Place which will not present in a; 
        }
        static int FindK(int[] a,int k)
        {
            int l=1;int h=FindMax(a);int mid=0;
            while(l<=h)
            {
                mid=(l+h)/2;
                int midN=FindKelement(a,mid);
                if(midN==k)
                {
                    return mid;
                }
                if(midN>k)
                {
                    h=mid-1;
                }
                else
                {
                    l=mid+1;
                }
            }
            return mid;
        }
        static int FindKelement(int[]a,int k)
        { int count=0;
            if(k<a[0] && k>0)
            {
                return k;
            }
            else if(k>a[0] && k<a[a.Length-1])
            {
            int ans=-1;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]<k)
                {
                count++;  
                
                }
            }
                
            }
            else if (a[a.Length-1]<k)
            {
                return k-a.Length;
            }
            return k-count;
            
        }
        static int FindMax(int[]a)
        {   int max=a[0];
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








// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={4,7,9,10};
     int k=7;
     Console.WriteLine(FindKelement(a,k));
    }
     static int FindKelement(int[]a,int k)
    { int count=0;
        if(k<a[0] && k>0)
        {
            return k;
        }
        else if(k>a[0] && k<a[a.Length-1])
        {
        int ans=-1;
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]<k)
            {
             count++;  
             
            }
        }
            
        }
        else if (a[a.Length-1]<k)
        {
            // Console.WriteLine(a[a.Length-1]);
            return k+a.Length;
        }
        return k-count;
        
    }
}