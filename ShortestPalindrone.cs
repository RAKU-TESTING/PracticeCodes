// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Text;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string s="aacecaaa";
       ShortestPalindrome(s);
    }
    static void ShortestPalindrome(string s)
    {
        int l=1;
        StringBuilder sb=new StringBuilder(s);
        while (!CheckPalindrome(sb.ToString()))                                                                                                                                                                                        
        {
            sb.Insert(0,s[l]);
            l++;
            //  Console.WriteLine(sb.ToString());  
        }
        if(CheckPalindrome(sb.ToString()))
        {
          Console.WriteLine(sb.ToString());   
        }
    }
    static bool CheckPalindrome(string sb)
    {
        string b="";
        for(int i=sb.Length-1;i>=0;i--)
        {
            b=b+sb[i];
        }
        if(sb.ToString().Equals(b))
        {
            return true;
        }
        return false;
    }
}