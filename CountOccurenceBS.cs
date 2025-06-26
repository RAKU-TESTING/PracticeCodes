using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={3,4,4,13,13,20,40};
        int x=20;
int b=(Lastoccurence(a,x)-Firstoccurence(a,x))+1;
      Console.WriteLine("No.of occurence="+b);
    }
    
    static int Firstoccurence(int[] a,int x)
    {
        int l=0;int h=a.Length-1;
        int ans=0;
        while(l<=h)
        {
          int  mid=(l+h)/2;
            if(a[mid]==x)
            {
                ans=mid;
                h=mid-1;//HERE KEEP IN MIND WE ARE LOOKING FOR FIRST OCCURENT SO WE LOOK IN Left side and For last occurence right side;
                
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
    static int Lastoccurence(int[] a,int x)
    {
        int l=0;int h=a.Length-1;
        int ans=0;
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