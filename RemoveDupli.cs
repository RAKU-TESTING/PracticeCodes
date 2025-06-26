// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
       int []a={1,1,1,3,2,6,3,2};
        // Remove(a);
          RemoveNew(a);
        foreach (var c in a)
        {
            Console.WriteLine(c);
        }
      
    }
    static void Remove(int[]a)
    {
        List <int> r=new List<int>();
        foreach(var b in a)
        {  
            if(!r.Contains(b))
          {
            r.Add(b);
          }
        }
        for(int i=0;i<a.Length;i++)
        {
            if(i<r.Count)
            {
                a[i]=r[i];
            }
            else
            {
                a[i]=0;
            }
        }
    }
    static void RemoveNew(int []a)
    {
        HashSet <int> h=new HashSet<int>();
        int index=0;
         foreach(var b in a)
        {  
            if(h.Add(b))
          {
            a[index++]=b;
          }
        }
        while(index<a.Length)
        {
            a[index++]=0;
        } 
        
    }
}



using System;

class Program
{
    static int RemoveDuplicates(int[] arr, int n)
    {
        int i = 0;
        for (int j = 1; j < n; j++)
        {
            if (arr[i] != arr[j])
            {
                i++;
                arr[i] = arr[j];
            }
        }
        return i + 1;
    }

    static void Main()
    {
        int[] arr = { 1, 1, 2, 2, 2, 3, 3 };
        int n = arr.Length;
        int k = RemoveDuplicates(arr, n);

        Console.WriteLine("The array after removing duplicate elements is:");
        for (int i = 0; i < k; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
