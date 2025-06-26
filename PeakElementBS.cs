



using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={1,5,1,2,1};
        
        Console.WriteLine(PeakElement(a));
        
    }
    static int PeakElement(int []a)
    {
        int l=1;int h=a.Length-2;int ans=-1;int mid=-1;
          
          if(a[0]>a[1])
          {return a[0];}
          if(a[a.Length-2]<a[a.Length-1])
          {return a[a.Length-1];}
           while(l<=h)
         {
           mid=(l+h)/2;
           if(a[mid]>a[mid+1] && a[mid]>a[mid-1])
           { 
             return a[mid];
            }
            else if(a[mid]>a[mid-1]){
                l=mid+1;
            }
            else
            {
                h=mid-1;
            }
         }
        return ans;
    }
}    