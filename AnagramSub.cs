// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
          string s="cbaebabacd";
          string p="abc";//Heres you want to Find substring of String s made from p.
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
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
                                                                                                                                                                                    
public class HelloWorld
{
    public static void Main(string[] args)
    {
       string s="cbaebabacd";
          string p="abc";
          List<int> Scount = new List<int>(new  int[26]);
        List<int> Pcount = new List<int>(new int[26]);
        List<int>ans=new List<int>();
          int a=p.Length;
          for(int i=0;i<a;i++)
          {
              Pcount[p[i]-'a']++;
          }
          for(int i=0;i<s.Length;i++)
          {
              Scount[s[i]-'a']++;
              if(i>a-1)
              {
                  Scount[s[i-a]-'a']--;
              }
              bool anagram=true;
              for(int j=0;j<26;j++)
              {
                  if(Scount[j]!=Pcount[j])
                  {
                      anagram=false;
                  break;
                   }
              }
              if(anagram) {ans.Add(i-a+1);}     
              }
              foreach(int d in ans)
               {
        Console.WriteLine(d);
               }
    }
    
}