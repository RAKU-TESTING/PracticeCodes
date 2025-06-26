// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={14,9,15,12,6,8,13};
        SelectionSort(a);
        foreach(var c in a)
        {
            Console.WriteLine(c);
        }
    }
    public static int[] InsertionSort(int []a)
{
    for (int i=0;i<a.Length;i++)
    { int j=i;
      while(j>0 && a[j]<a[j-1])
      {
          int b=a[j];
          a[j]=a[j-1];
          a[j-1]=b;
          j--;
      }
    }
    return a;
    
}
    
}
        