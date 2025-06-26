
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string c="(1+(2*3)+((8)/4))+1";
        string b= "(1)+((2))+(((3)))";
        string a="()(())((()()))";
        int sum=0;int max=0;
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]=='(')
            {
                sum++;
            }
            else if(a[i]==')')
            {
                sum--;
            }
            if(sum>max)
            {
                max=sum;
            }
        }
        Console.WriteLine(max);
    }
}