// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={0,3,4,7,10,9};
        int k=5;
        Console.WriteLine(AggresiveCows(a,k));
    }
    static int AggresiveCows(int[]a,int k)
    {
        Array.Sort(a);
        int l=a[0];
        int h=a[a.Length-1];
        int mid=-1;
        int ans=-1;
        while(l<=h)
        {
            mid =(l+h)/2;
    bool MidN=CanWePlace(a,mid,k);
    if(MidN)
    {
        ans=mid;
        l=mid+1;
    }
    else{
        h=mid-1;
    }
    }
    return ans;
    }
    static bool CanWePlace(int[]a,int mid,int k)
    {
        int catcows=1;int last=a[0];
         for(int i=1;i<a.Length;i++)
        {
            if(a[i]-last>=mid)
            {
                catcows++;
                last=a[i];
            }
        }
        if(catcows>=k)
        {return true;}
    
        return false;
    }
}




//below are My ans;
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int []a={10,1,2,7,5};
       int k=3;
       Console.WriteLine(FindMinDiff(a,k));
    }
    static int FindMinDiff(int[]a,int k)
    {
        int max=FindMax(a);
        int min=FindMin(a);
        int ans=(max-min)/(k-1);
     Console.WriteLine(ans);
        int l=0;int r=1;int count=0;int diff=0;int minmax=ans;
        while(ans==4){
       for(int i=0;i<a.Length-1;i++)
        {
         for(int j=i+1;j<a.Length;j++)
         {
             diff=Math.Abs(a[j]-a[i]);
            //Console.WriteLine(diff);
             if(diff==ans)
             { 
                 
                // Console.WriteLine(diff);
                 count++;
                  Console.WriteLine(count);
             }
             
         }
        //  Console.WriteLine(ans);
         if(count==k-1)
             {
                // Console.WriteLine(ans);
                 return ans;
             }  
            
            
        }
         ans--;
        }
        
        // Console.WriteLine(count);
       
        return -1;
    }
    static int FindMax(int[]a)
    {
        int max=int.MinValue;
        for(int i=0;i<a.Length;i++)
        {   if(a[i]>max)
            {
                max=a[i];
            }
        }
        // Console.WriteLine(max);
        return max;
    
    }
    static int FindMin(int []a)
    {
        int min=int.MaxValue;
       for(int i=0;i<a.Length;i++)
        {   if(a[i]<min)
            {
        min=a[i];
            }
        }
        // Console.WriteLine(min);
        return min;
    }
    
}








// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string []args)
    {
     int[]a={4,2,1,3,6};
     int n=1;
     int pos=0;
     int c=maxdiff(a,n,pos);
     Console.WriteLine(c);
        
    }

static  int maxdiff(int[]a,int n,int pos)
{
    Array.Sort(a);
    List<int> num=new List<int>(a);
    int count=0;
    while(n<=5)
    {
        int ans=0;
        for(int i=0;i<pos+1;i++)
        {
            ans=a[i]+n+ans;
            
        }
        
        if(num.Contains(ans))
        {
            // Console.WriteLine(ans);
            ans=ans+n;
            count++;
            if(count==1)
            {
           return n;    
            }
            if(num.Contains(ans) || ans<a[a.Length-1] )
        {
            count++;
            if(count==1)
           {
          return n;    
           }
            // Console.WriteLine(count);
            // return true;
        }
            // Console.WriteLine(count);
        }
        
        
        // Console.WriteLine(ans);
        n++;
    }
    
    return -1;
}}





// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int []a={10,1,2,7,5};
       int k=3;
       Console.WriteLine(FindMinDiff(a,k));
    }
    static int FindMinDiff(int[]a,int k)
    { 
        Array.Sort(a);       
        int max=a[a.Length-1];
        int min=a[0];
        int ans=(max-min)/(k-1);
    //  Console.WriteLine(ans);
        int l=0;int r=1;int count=0;int diff=0;int minmax=ans;
        while(ans>0){
       for(int i=0;i<a.Length-1;i++)
        {
         for(int j=i+1;j<a.Length;j++)
         {
             diff=Math.Abs(a[j]-a[i]);
            //Console.WriteLine(diff);
             if(diff==ans || diff!<ans)
             { 
                if(a[j]-a[j-1]>=ans)
                { // Console.WriteLine(diff);
                 count++;
                }
                //   Console.WriteLine(count);}
             }
             
         }
        //  Console.WriteLine(ans);
         if(count==k-1)
             {
                // Console.WriteLine(ans);
                 return ans;
             }  
            
            
        }
         ans--;
        }
        
        // Console.WriteLine(count);
       
        return -1;
    }
    static int FindMax(int[]a)
    {
        int max=int.MinValue;
        for(int i=0;i<a.Length;i++)
        {   if(a[i]>max)
            {
                max=a[i];
            }
        }
        // Console.WriteLine(max);
        return max;
    
    }
    static int FindMin(int []a)
    {
        int min=int.MaxValue;
       for(int i=0;i<a.Length;i++)
        {   if(a[i]<min)
            {
        min=a[i];
            }
        }
        // Console.WriteLine(min);
        return min;
    }
    
}






// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string []args)
    {
     
     int[]a={1,2,4,8,9};
     
     int k=3;
     int c=maxdiff(a,n,k);
     Console.WriteLine(c);
        
    }
    static void AggresiveCow(int[]a,int k)
    {
        Array.Sort(a);
         int n=(a[a.length-1]-a[0])/k-1;
         int l=a[0];
         int h=a[a.length-1];
         int mid=-1;
         while(l<h)
         {
             mid=(l+h)/2;
         }
         
        
    }

static  int maxdiff(int[]a,int n,int k)
{
    Array.Sort(a);
    List<int> num=new List<int>(a);
    int count=0;
    while(n==3)
    {
        int ans=0;
        for(int i=0;i<i+1;i++)
        {
            ans=a[i]+n+ans;
            
        }
        
        if(num.Contains(ans))
         {
        // count++; 
        // if(count==k-1)
        //     {
        //   return n;    
        //     }
            while(count<k-1)
            {
                ans=ans+n;
                count++;
            // Console.WriteLine(ans);
        //     ans=ans+n;
        //     count++;
        //     if(count==k-1)
        //     {
        //   return n;    
        //     }
        //     if(num.Contains(ans) || ans<a[a.Length-1] )
        // {Console.WriteLine("Yess");
        //     count++;
        //     if(count==k-1)
        //   {
        //   return n;    
        //   }
        //     // Console.WriteLine(count);
        //     // return true;
        // }
            // Console.WriteLine(count);
        }}
        if(count==k-1)
            {
          return n;    
            }
        
        // Console.WriteLine(ans);
        n++;
        // return -1;
    }
    
    return -1;
}}

