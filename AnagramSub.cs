// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
          string s="cbaebabacd";
          string p="abc";
          bool r=false;
          string a;
          for(int i=0;i<=s.Length-3;i++)
          {
              if(p.Contains(s[i]) && p.Contains(s[i+1]) && p.Contains(s[i+2]))
              {
                    a=s.Substring(i,3);
                    char[] b=a.ToCharArray();
              Array.Sort(b);
              for (int j=0;j<b.Length;j++)
              {
                  r=false;
                  if(p[j]==b[j])
                  {
                     r=true;
                  }
              }
              if(r)
              {
                  Console.WriteLine(a);
              }
             
               }
              
             
          }   
    }
}