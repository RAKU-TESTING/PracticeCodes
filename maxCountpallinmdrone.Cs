
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string a="baaa";
       
        Console.WriteLine("maxpallindrone-"+maxPallindrome(a));
       
    }
    static int maxPallindrome(string a)
    {
        if(a.Length==1)
        {
            return 1;
        }
         int l=0;int r=0;int count=0;
        string b="";int left=0;int right=0;
        while(l<a.Length)
        {
            b=a.Substring(l, r - l + 1);
            if(b.Length>=1)
            {
                CheckPallindrome(b);
                if(CheckPallindrome(b))
                {
                   count++;
                }
            }
            r++;
            if(r==a.Length)
            {
                l++;
                r=l;
            }
        }
         
        return count;
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