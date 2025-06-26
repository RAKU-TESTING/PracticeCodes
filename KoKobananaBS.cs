


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={7, 15, 6, 3};
        int n=5;
         Console.WriteLine(MinBanana(a,n));
    
    }
    static int MinBanana(int []a,int n)
    {
        int l=1;int h=FindMax(a);int ans=-1;
        // Console.WriteLine(h);
        while(l<=h)
        {
            int mid= (l+h)/2;
            int MidN=Check(a,mid);
            // Console.WriteLine(MidN);
            if(MidN<=n)
            {
                ans=mid;
                //please pay your attention on this also
            }
            if(MidN>n)
            {
                l=mid+1;
            }
            else
            {
                h=mid-1;
            }
        }
        return ans;
    }
     static int Check(int []a,int mid)
    {int count=0;int index=0;
        while( index<a.Length)
        {
           count+=(int)Math.Ceiling((double)a[index]/mid);
           index++;
        }
        
        return count;
    }
    static int FindMax(int []a)
    {int max=int.MinValue;
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