// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    { string a="677";
        CountAndSay(a);
    }
    static void CountAndSay(string a)
    {   String b="";
        
        Dictionary<char,int> num=new Dictionary<char,int>();
        for(int i=0;i<a.Length;i++)
        { 
            if(num.ContainsKey(a[i]))
            {
                num[a[i]]++;
                
            }
            else
            {
                num[a[i]]=1;
            }
        }
        for(int i=0;i<num.Count;i++)
        {
            // string count=
            // char value=a[i];
            b+=num[a[i]].ToString()+a[i];
        }
        Console.WriteLine(b);
        
    }
}









using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    { int a=6;
    Console.WriteLine(CountAndSay(a));
    }
    static string CountAndSay(int a)
    {
        if(a==1)
      {
        return "1";
       }
        string b="";
        string c=CountAndSay(a-1);
         int count = 1;
         int l=0;

        for (int r = 1; r < c.Length; r++)
        {
            if (c[l] == c[r])
            {
                count++;
            }
            else
            {
                b += count.ToString() + c[l];
                l = r;
                count = 1;
            }
        }

        // Append the last group of characters
        b += count.ToString() + c[l];
        // Dictionary<char,int> num=new Dictionary<char,int>();
        // for(int i=0;i<c.Length;i++)
        // { 
        //     if(num.ContainsKey(c[i]))
        //     {
        //         num[c[i]]++;
        //     }
        //     else
        //     {
        //         num[c[i]]=1;
        //     }
        // }
        // for(int i=0;i<num.Count;i++)
        // {
        //     // string count=
        //     // char value=a[i];
        //     b+=num[c[i]].ToString()+c[i];
        // }
        // Console.WriteLine(b);
        return b;
        
    }
}