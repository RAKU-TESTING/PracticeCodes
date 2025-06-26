// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string a="babad";
       
        Console.WriteLine("MaxLength-"+LongestPallindrome(a));
       
    }
    static int LongestPallindrome(string a)
    {
         int l=0;int r=0;int length=0;int maxlength=0;
        string b="";int left=0;int right=0;
        while(l<a.Length)
        {
            b=a.Substring(l, r - l + 1);
            if(b.Length>1)
            {
                CheckPallindrome(b);
                if(CheckPallindrome(b))
                {
                    if(b.Length-1>maxlength)
                    {
                        maxlength=b.Length;
                       left=l;
                        right=r;
                    }
                }
            }
            r++;
            if(r==a.Length)
            {
                l++;
                r=l;
            }
        }
         Console.WriteLine("left pointer-"+left);
        Console.WriteLine("right pointer-"+right);
        return maxlength;
    }
    static bool CheckPallindrome(string d)
    { 
        string c="";
    //   bool d=false;
        for(int i=d.Length-1;i>=0;i--)
        {
          c=c+d[i];
        }
        if(c.Equals(d))
        {
           return true;
        }
        
      return false;  
   }}