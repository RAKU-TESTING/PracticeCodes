using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       int m=69;int n=4;
       Console.WriteLine(RootElement(m,n));
    }
    static int RootElement(int m, int n)
    {
        int l=1;int h=m;int    mid=-1;
        while(l<=h)
        {
          mid=(l+h)/2;
        //   Console.WriteLine(h);
        int midN=Check(mid,n,m);
            if(midN==1)
            {
                return mid;
            }
            if(midN==0)
            { l=mid+1;}
            else
            {h=mid-1;}
        }
        return -1;
    }
    static int Check(int mid,int n,int m)//in this for overflow condition learn it carefully
    {
         long ans=1;
        for(int i=1;i<=n;i++)
        {
            ans=ans*mid;
        }
        if(ans > m)
        {
            return 2;
        }
        if(ans==m)
        {
            return 1;
        }
        return 0;
    }
}