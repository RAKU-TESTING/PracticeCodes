// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
class GFG {

  // the number of subarrays with at most K distinct
  // elements
  static int most_k_chars(string s, int k)
  {
    if (s.Length == 0) 
    {
      return 0;
    }
    Dictionary<char, int> map = new Dictionary<char, int>();
    int ans = 0, l = 0;

    for (int r = 0; r < s.Length; r++) 
    {
        if(map.ContainsKey(s[r]))
       {
     map[s[r]]++;
       }
     
      else
        map.Add(s[r], 1);
        
        
      while (map.Count > k) 
      {
          
           if(map.ContainsKey(s[l]))
           {
            map[s[l]]--;
           }
           else
            map.Add(s[l], -1);
            if (map[s[l]] == 0)
            {
             map.Remove(s[l]);
            }
            l++;
      }
        ans += r - l + 1;
    }
    return ans;
  }
  static int exact_k_chars(String s, int k)
  {
    return most_k_chars(s, k);
    //- most_k_chars(s, k - 1);
  }
  public static void Main(string []args)
  {
    string s1 = "aba";
    int k = 2;
    Console.WriteLine("Total substrings with exactly "
                      + k + " distinct characters : "
                      + exact_k_chars(s1, k));

    string s2 = "cdad";
    k = 4;
    Console.WriteLine("Total substrings with exactly "
                      + k + " distinct characters : "
                      + exact_k_chars(s2, k));
  }
}





MY logic 
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    { string a="abab";
        Totalsusbtring(a);
    }
    static void Totalsusbtring(string a)
    { int l=0;int r=0;int ans=0;int result=0;
        while(l<a.Length)
        {
            ans=r-l+1;
            //  Console.WriteLine(ans);
            r++;
            if(r==a.Length)
            {
                l++;
                r=l;
                result+=ans;
                 
                ans=0;
            }
           
            
        } Console.WriteLine(result);
       
    }
}