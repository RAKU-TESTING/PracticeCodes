// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Text;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {   string s="ababab";
       Console.WriteLine(LongestPrefix(s));
    }
    static string LongestPrefix(string s)
    {
        int l=0;
        List<string> prefix=new List<string>();
        List<string> suffix=new List<string>();  
        StringBuilder sb=new StringBuilder();
        StringBuilder sbb=new StringBuilder();
        for(int r=0;r<s.Length-1;r++)
        {
            string substring =s.Substring(l,r+1);
            prefix.Add(sbb.Append(substring).ToString());
        
            sbb.Clear();
            
        }
        int i=1;int j=s.Length-1;
        while(i<s.Length)
        {
             string substring =s.Substring(i,j);
             suffix.Add(sb.Append(substring).ToString());
             i++;
             j--;
             sb.Clear();
        }
        // int maxlength=0;
        
        // // Console.WriteLine(prefix.Count);
        // for(int index=0;index<prefix.Count;index++)
        // {
        //   if(prefix[index].Length>maxlength && suffix.Contains(prefix[index]))
        //         {
        //             maxlength=prefix[index].Length;
        //         }
        // }
        // foreach(var f in prefix)
        // {if(f.Length==maxlength)
        // {
        //     return f;
        // }}
        
        //         Console.WriteLine(maxlength);
        // foreach(var f in prefix)
        //  {
            
            
        //         // Console.WriteLine(maxlength);
        //     if(f.Length==maxlength)
        //     {
        //         return f;
        //     }    
           
        // }
          string longest = "";
        foreach (var p in prefix)
        {
            if (suffix.Contains(p))
            {
                if (p.Length > longest.Length)
                {
                    longest = p; 
                }
            }
        }

        
        
        
         return longest;
    }
    
}
   
