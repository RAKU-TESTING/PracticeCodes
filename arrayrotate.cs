// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={1,2,3,4,5,6,7};
        int place=7;
        // ShiftRight(a,place);
        // ShiftRightnew(a,place);
        ShiftLeftnew(a,1);
        int []c={1,0,2,3,0,4,0,1};
        MoveZero(c);
        
        // for(int i=0;i<a.Length;i++)
        // {
        //   a[i]=a[(i+place)%a.Length];
        // }
        foreach(var d in a)
        {
            Console.WriteLine(d);
        } 
    }
    static void ShiftRight(int []a,int place)
    {
        int []b =new int[a.Length];
    for(int i=0;i<a.Length;i++)
    {
        b[i]=a[i];
    }
        for(int i=0;i<b.Length;i++)
        {
          a[(i+place)%a.Length]=b[i];
        }
    }
    static void ShiftRightnew(int [] a,int place)
    {
        place=place%a.Length;
        Reverse(a,0,a.Length-1);
        Reverse(a,0,place-1);
        Reverse(a,place,a.Length-1);
    }
    static void ShiftLeftnew(int []a, int place)
    {
        place=place%a.Length;
        Reverse(a,0,a.Length-1);
        Reverse(a,0,(a.Length-1)-place);
        Reverse(a,a.Length-place,a.Length-1);
    }
    static void Reverse(int []a,int start,int end)
    {
        while(start<end)
        {
        int e=a[start];
        a[start]=a[end];
        a[end]=e;
        start++;
        end--;
        }
    }
    static void MoveZero(int [] c)
    {
        int i=0;int j=1;
        while(j<c.Length)
        {
            if(c[i]==0 && c[j]!=0)
            {
                Swap(c,i,j);
            }
            if(c[i]!=0)
            {
                i++;
            }
            j++;
        }
    }
    static void Swap(int[]c,int i ,int j)
    {
        int k=c[i];
        c[i]=c[j];
        c[j]=k;
    }
}