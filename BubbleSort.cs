// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={14,9,15,12,6,8,13};
        BubbleSort(a);
        foreach(var c in a)
        {
            Console.WriteLine(c);
        }
    }
    public static int[] BubbleSort(int []a)
{
    for (int i=a.Length;i>=0;i--)
    {
        for(int j=0;j<i-1;j++)
        {
            if(a[j]>a[j+1])
            {
              int b=a[j];
              a[j]=a[j+1];
              a[j+1]=b;
            }
        }
}return a;
    
}}