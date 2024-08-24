// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string a="GEEKS FOR GEEKS IS FOR GEEKS";
        string []b=a.Split(' ');
        Dictionary <string,int> c = new Dictionary <string,int>();
         foreach(var d in b)
            {
                if(c.ContainsKey(d))
                {
                    c[d]++;
                }
                else
                {
                    c[d]=1;
                }
            }
            foreach(var e in c)
            {
                Console.WriteLine(e.Key+"-"+e.Value);
            }
}            
}
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Dictionary<string,int>a=new Dictionary<string,int>();
       string[] b={"Aman","Nitin","Sachin","Sumit","Dinesh","Rakesh","Dhaval","Neeraj","Aman","Rakesh"};
       foreach(var c in b)
       {
           if(a.ContainsKey(c))
           {
               a[c]++;
            }
           else
           {
               a[c]=1;
           }
       }
       foreach(var d in a)
    {Console.WriteLine(d.Key+"-"+d.Value);
    }
    }
}
