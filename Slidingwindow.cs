// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
         int []arr={2,5,1,7,10,11};
         int k=14;
         
         int l=0;int r=0;
         int sum=0;int maxlen=0;int maxsum=0;
         int maxl=0;int maxr=0;
         while(r<arr.Length)
         {
             sum=sum+arr[r];
             
             while(sum>k)
             {
                 sum=sum-arr[l];
                 l=l+1;
             }
             if(sum<=k )
              {   
                 if(sum>maxsum||maxlen<r-l+1 )
                 {   maxsum=sum;
                     maxlen=r-l+1;
                     maxl=l;
                     maxr=r;
                     
                     
                 }
                 
             }
             r++;
         }
         Console.WriteLine(maxlen);
        //  Console.WriteLine(maxl);
        //   Console.WriteLine(maxr);
         for(int i=maxl;i<=maxr;i++)
         {
             Console.WriteLine(arr[i]);
         }
              
            
         
             
             
    }
}