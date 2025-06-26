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
        if(a.Length!=b.Length)//Here the anagram means "Worth" to "Throw";
        {
            e=false;
        }
        else{
        char[] c= a.ToCharArray();//Coverted Them in Char array        
        char[] d= b.ToCharArray();//Coverted Them in Char array
        Array.Sort(c);//Sort
        Array.Sort(d);//Sort
        for(int i=0;i<c.Length;i++)
        {
            if(c[i]!=d[i])  //Check each Char;
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