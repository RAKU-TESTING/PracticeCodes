// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] a={"sunday","monday","tuesday","wednesday","Thursday","friday","Saturday"};
         string b=Console.ReadLine();
            char c=b[0];
        for(int i=0;i<a.Length;i++)
        { 
           
            string d=a[i];
            char e=d[0];
             if(c==e)
             {
                 Console.WriteLine("today is"+" "+a[i]);
                 break;
               }
            
        }
}}


static bool Check(string b)//we can also check for this
{
    string e="sunday";
    string f=b.ToLower();
    for(int i=0;i<e.Length;i++)
    {
          string g=e.Substring(i,(e.Length-j));
            Console.WriteLine(g);
            if(g.Equals(f))
            { 
                
                return true; 
            }
        }
    }
    
    
    
 return false;
    
    
    
    
    
}