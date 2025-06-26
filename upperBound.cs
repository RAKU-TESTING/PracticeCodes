using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={3,5,8,9,15,19};//Upper bound means smallest index which value is greater than x i.e a[index]>x 
        int x=4;
      Console.WriteLine(UpperBound(a,x));
    }
    static int UpperBound(int[] a,int x)
    {
        int l=0;int h=a.Length-1;
        int ans=a.Length;
        while(l<=h)
        {
          int  mid=(l+h)/2;
            if(a[mid]>x)
            {
                ans=mid;
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