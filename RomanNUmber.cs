using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Dictionary<char,int> Rom=new Dictionary<char,int>{{'I',1},{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}};
        string s= "MCMXCIV";
        int sum=0;int l=0;
       while(l<s.Length)
          {
            
            if(l<s.Length-1 && Rom[s[l]]<Rom[s[l+1]])
            {
                sum+=Rom[s[l+1]]-Rom[s[l]];
                // Console.WriteLine(sum);
                l=l+2;
            }
            else 
            {
                sum+=Rom[s[l]];
                l++;
            }
        
            // Console.WriteLine(Rom[s[r]]);
             
        }
        Console.WriteLine(sum);
        
    }
}