using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] S= {3,2,1,7,6};
        int index=0;
        Reverse(S,index);
        
    }
    public static void Reverse(int[] S,int index)
    {
        if(index==S.Length)
    {
        return;
    }
        Reverse(S,index+1);
        Console.WriteLine(S[index]);
    }
}