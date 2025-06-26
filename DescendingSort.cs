
using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={15,7,8,1,3,5,11};
        Array.Sort(a);//we are Sorted With Ascending Order
        Array.Reverse(a);//then We actually reversing the current array for descending
        foreach(var b in a)
        {
            Console.WriteLine(b);
        }
}}
