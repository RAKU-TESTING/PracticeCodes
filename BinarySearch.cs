
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={1,3,9,2,4,7,12,5};
        Array.Sort(a);
        int mid=a[(a.Length/2)-1];
        
        int b=int.Parse(Console.ReadLine());
        if(b<=mid)
        {
        for(int i=0;i<mid+1;i++)
        {
            if(a[i]==b)
            {
                Console.WriteLine("Index of element is"+" "+i);
            }
        }}
        else
        {
            for(int i=mid;i<a.Length;i++)
        {
            if(a[i]==b)
            {
                Console.WriteLine("Index of element is"+" "+i);
            }
        }
            
        }
    }}
     