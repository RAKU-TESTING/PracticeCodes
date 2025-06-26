using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int []a={5,4,2,6,8};
        int []b={1,3,7,0,8};
        int[] c=new int[a.Length+b.Length];
        for(int i=0;i<a.Length;i++)
        {
            c[i]=a[i];
        }
        int index=a.Length;
        for(int j=0;j<b.Length;j++)
        {
            
            c[index]=b[j];
            index++;
        }
         Array.Sort(c);
        foreach(int d in c)
        {
            Console.WriteLine(d);
        }
    }
}








// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;//this for sorted array add two pointer method

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int []a={1,2,3,4,5};
        int []b={6,7,8,9,10};
        int[] c=new int[a.Length+b.Length];
        int left=0;
        int right=0;
        int i=0;
        while((left<a.Length || right <a.Length)&& i<a.Length)
        {
            if(a[left]<b[right])
            {
                c[i]=a[left];
                left++;
               
            }
            else if(a[left]>b[right])
            {
                c[i]=b[right];
                right++;
                
            }
            i++;
        }
        while(left<a.Length)
        {
             c[i]=a[left];
                left++;
                i++;
        }
        while(right<a.Length)
        {
             c[i]=b[right];
                right++;
                i++;
        }
        
        foreach(int d in c)
        {
            Console.WriteLine(d);
        }
    }
}