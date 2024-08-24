
using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={1,3,9,2,4,7,12,5};
        int b=int.Parse(Console.ReadLine());
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]==b)
            {
                Console.WriteLine("Index of element is"+" "+i);
            }
        }
     
     
     
     
    }
    
}