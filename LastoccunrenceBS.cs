using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={3,4,4,13,13,20,40};
        int x=40;
      Console.WriteLine(Lastoccurence(a,x));
    }
    static int Lastoccurence(int[] a,int x)
    {
        int l=0;int h=a.Length-1;
        int ans=-1;
        while(l<=h)
        {
          int  mid=(l+h)/2;
            if(a[mid]==x)
            {
                ans=mid;
                 l=mid+1;
            }
            else if(a[mid]>x)
            {
               h=mid-1;
            }
            else
            {
            l=mid+1;    
            }
        }
        return ans;
    }
}
