using System;
using System.Text;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      string  a = "srk";string  b = "rksrks";
        // Console.WriteLine(RepeatedStringMatch(a,b));
       Check(a,b); 
       
    }
    static void Check(string a, string b)
    { int count=0;
        StringBuilder sb=new StringBuilder();
        while (b.Length>sb.Length)
        {
            count++;
            sb.Append(a);
        }
        if(!sb.ToString().Contains(b))
        {
            count++;
            sb.Append(a);
        }
        else
        {
            Console.WriteLine(count);
        } 
        if(sb.Length>b.Length)
        {
            if(!sb.ToString().Contains(b))
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine(count);
            }
        }
        
    }
    static int  RepeatedStringMatch(string sb,string a,string b,int count)
    {   
        int l=0;int r=0;
        // StringBuilder sb=new StringBuilder();
        // while (b.Length>sb.Length)
        // {
        //     count++;
        //     sb.Append(a);
        // }
        
        // Console.WriteLine(sb);
       while(l<sb.Length)
        {
             string c=sb.ToString().Substring(l, r - l + 1);
            //   Console.WriteLine(sb.Length);
             if(c.Length==b.Length)
             {
                 if(c.Equals(sb))
                 {
                     return count;
                 }
                 
             }
             r++;
             if(r==sb.Length)
             {
                 l++;
                 r=l;
                 c="";
             }
            
        }
        return -1;
    }
}






//more simple


using System;
using System.Text;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        string a="abc";string b="cdabcdab";
       Console.WriteLine(Check(a,b));
    }
    static int Check(string a,string b)
    {  int count=0;
        StringBuilder sb=new StringBuilder();
        while(b.Length>sb.Length)
        {
            count++;
            sb.Append(a);
        }
        if(sb.ToString().Contains(b))
        {
            return count;
        }
        else
        {
            count++;
            sb.Append(a);
        }
        if(sb.Length>b.Length && sb.ToString().Contains(b))
       {
           return count;
       }
       else
       {
           Console.WriteLine("NOtFound");
        }
            return -1;
       }        
        
        
       
    }
    