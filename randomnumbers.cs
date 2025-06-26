// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    { var random=new Random();
         int randomNumber = random.Next(0000, 10000);
         
         Console.WriteLine(randomNumber.ToString("0000"));
         string result="000";
         int a=7;
         result=result+a;
         Console.WriteLine(result);
         int b=222;
         int digit=0;
         while(b>0)
         {
             b=b/10;
             digit++;
         }
         string num="";
         for(int i=0;i<3;i++)
         {
             num=num+"0";
         }
         Console.WriteLine(num);
}}