

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {  List<int>a=new List<int>{1,2,3,4,5};
        List<int> result = rotLeft(a,4);
        foreach(int c in result)
        {
            Console.WriteLine(c);
        }
        
      

    } 
    public static List<int> rotLeft(List<int> a, int d)
    {     int n=a.Count;
          List <int> result =new List<int>(new int[n]);
for(int i=0;i<a.Count;i++)
{
    result[(i+d)%a.Count]=a[i];
}
return result;
    }
}