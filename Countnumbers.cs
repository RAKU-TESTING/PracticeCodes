// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int []a={1,2,2,1};
        Dictionary<int,int> b=new Dictionary<int,int>();
        for(int i=0;i<a.Length;i++)
        {
            if(b.ContainsKey(a[i]))
            {
                b[a[i]]++;
            }
            else
            {
                b[a[i]]=1;
            }
        }
        foreach(var c in a)
        {
            if(b[c]==1)
            {
            Console.WriteLine(c);
            }
        }
        

    }
}