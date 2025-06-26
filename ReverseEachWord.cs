using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       string a="the sky is blue";
    
    ReverseEveryWord(a);
    }
    static void ReverseEveryWord(string a)
    {
        string []words=new string[a.Length];
        words=a.Split(" ");
        // words.Trim();
        Array.Reverse(words);
        foreach (var final in words)
        {
            final.Trim();
            Console.Write(final+" ");
        }
    }
}