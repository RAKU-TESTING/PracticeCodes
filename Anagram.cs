// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {  
        Console.WriteLine("Enter First String"); 
        string a=Console.ReadLine().ToLower();
        Console.WriteLine("Enter Second String"); 
        string b=Console.ReadLine().ToLower();
        bool e= true;
        if(a.Length!=b.Length)
        {
            e=false;
        }
        else{
        char[] c= a.ToCharArray();
        char[] d= b.ToCharArray();
        Array.Sort(c);
        Array.Sort(d);
        for(int i=0;i<c.Length;i++)
        {
            if(c[i]!=d[i])
            {
                e=false;
            }
        }
        }
        if(e)
        {
            Console.WriteLine("This is Anagram");
        }
        else
        {
             Console.WriteLine("This is Not Anagram");
        }
    }
}