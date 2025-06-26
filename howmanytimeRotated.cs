// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler



using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={2,1};
        
        Console.WriteLine(MinimumElement(a));// in rotate array how many times array toatated means what is the index of minimum value 
        
    }
    static int MinimumElement(int []a)
    {
        int l=0;int h=a.Length-1;int ans=int.MaxValue;int mid=-1;int index=-1;
          while(l<=h)
        {
           mid=(l+h)/2;
          if(a[l]<=a[mid])
          {
              ans=Math.Min(ans,a[l]);
              l=mid+1;
          }
          else
          {
              ans=Math.Min(ans,a[mid]);
              {
                  h=mid-1;
            }
          }
          
        }
        return ans;
        
    }}