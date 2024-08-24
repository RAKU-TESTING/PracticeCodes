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