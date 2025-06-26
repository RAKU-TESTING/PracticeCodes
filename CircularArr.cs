

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




// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={1,2,3,4,5};
        
        int pos=0;
        RotateArray(a,pos);
        foreach(var c in a)
        {
              Console.WriteLine(c);
        }
        
    }
    static void RotateArray(int[] a,int pos)
    {   
        List<int> b=new List<int>(a);
       
        
        for(int i=0;i<a.Length;i++)
        {
        a[(i+pos)%a.Length]=b[i];
        // Console.WriteLine((i+pos)%a.Length);
        // Console.WriteLine(b[i]);
        }
    }

    
}