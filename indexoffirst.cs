// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
         string text="gffggg";
         string pattern="gfg";
         Console.WriteLine(FindMatching(text,pattern));
    }
    static int FindMatching(string text,string pattern)
    {   int r=0;int l=0;
     string a=""; 
        //  StringBuilder a=new StringBuilder();
       while(l<text.Length)
        {
            a=text.Substring(l,r-l+1);
            //  Console.WriteLine(a);
             if(a.Length==3)
             {
                 if(a.Equals(pattern))
                 {
                     return l;
                 }
             }
             r++;
             if(r==text.Length)
             {
                 l++;
                 r=l;
                 a="";
             }
            
        }
    
    return -1;
    }
}