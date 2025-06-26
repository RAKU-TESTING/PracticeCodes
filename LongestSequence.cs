// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={1,5,7,102,103,7,104,2,3,4};
        Console.WriteLine(LongestSequence(a));
       
    }
    public static int LongestSequence(int []a)
{  int longest=1;
    HashSet<int> s =new HashSet<int>(); 
    for(int i=0;i<a.Length;i++)
    {
        s.Add(a[i]);
    }
    foreach(var b in s)
    {
        if(!s.Contains(b-1))
        {
             int cnt = 1;
                int x = b;
                while (s.Contains(x + 1))
                {
                    x = x + 1;
                    cnt++;
                }
                longest = Math.Max(longest, cnt);
            }
        }
        return longest;
    }

    
}