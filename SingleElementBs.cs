



using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={1,1,2,3,3};
        
        Console.WriteLine(SingleElement(a));//this is My Code logic was right below this is Striver code
        
    }
    static int SingleElement(int []a)
    {
        int l=1;int h=a.Length-2;int ans=int.MaxValue;int mid=-1;int index=-1;
          if(a.Length%2==0)
          {
              return -1;
          }
          if(a[0]!=a[1]){return a[0];}
          if(a[a.Length-2]!=a[a.Length-1]){return a[a.Length-1];}
           while(l<=h)
         {
           mid=(l+h)/2;
           if(a[mid]!=a[mid+1] && a[mid]!=a[mid-1])
           { 
             return a[mid];
            } 
          if(mid%2!=0)
        {
                   if(a[mid+1]==a[mid])
                   {
            h=mid-1;
           }
          else
          {
            l=mid+1;
          }
          
        }
        else
        { 
            if(a[mid+1]==a[mid])
        {
            l=mid+1;
        }
        else if(a[mid-1]==a[mid] )
        { 
           h=mid-1;
        }
        // else
        // {
        //     ans=a[mid];
        //     return ans;
        // }
       
        
    }}
         return ans;
    }}










using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={1,1,2,3,3,4,4};
        
        Console.WriteLine(SingleElement(a));
        
    }
    static int SingleElement(int []a)
    {
        int l=1;int h=a.Length-2;int ans=-1;int mid=-1;
          if(a.Length%2==0)
          {
              return -1;
          }
          if(a[0]!=a[1])
          {return a[0];}
          if(a[a.Length-2]!=a[a.Length-1])
          {return a[a.Length-1];}
           while(l<=h)
         {
           mid=(l+h)/2;
           if(a[mid]!=a[mid+1] && a[mid]!=a[mid-1])
           { 
             return a[mid];
            } 
          if((mid%2!=0 && a[mid-1]==a[mid]) || (mid%2==0 && a[mid+1]==a[mid]))  
        {
                  
       l=mid+1;
          }
          else
          {
            h=mid-1;
          }
         }
         return ans;
    }}