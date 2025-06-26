using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      string a="Welcome to Csharp Corner";
    
    string [] b=a.Split(' ');
    for(int i=b.Length-1;i>=0;i--)
    {
        Console.Write(b[i]+" ");
    }
}
}
