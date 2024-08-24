using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={1,2,2,4,3,3,2,1};
 Dictionary <int,int> b=new Dictionary <int,int>();
 bool check=false;
 for(int i=0;i<a.Length;i++)
    {
        if(b.ContainsKey(a[i]))
        {
            b[a[i]]++;
        }
        else
        {
            b[a[i]]=1;
            check=true;
        }
    }    
    foreach (var d in b)
     {if(check){
         Console.Write(d.Key+" ");
     }
    }
}
    
}