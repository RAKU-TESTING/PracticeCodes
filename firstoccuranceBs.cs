
using Syatem;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={3,4,4,13,13,20,40};
        int x=4;
      Console.WriteLine(Firstoccurence(a,x));
    }
    static int Firstoccurence(int[] a,int x)
    {
        int l=0;int h=a.Length-1;
        int ans=-1;
        while(l<=h)
        {
          int  mid=(l+h)/2;
            if(a[mid]==x)
            {
                ans=mid;
                 h=mid-1;
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