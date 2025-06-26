    // Online C# Editor for free
    // Write, Edit and Run your C# code using C# Online Compiler

    using System;
    using System.Collections.Generic;
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            int []a={2,6,5,8,11};
            int sum=0;int k=15;
            bool l=false;
            int e=-1;
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    sum=a[i]+a[j];
                    if(sum==k)
                    {
                        Console.WriteLine("Yes");
                        l=true;
                        Console.WriteLine(a[i]+","+a[j]);
                        break;
                    }
                }
                
            }
            if(!l)
                { 
                    Console.WriteLine("No");
                    Console.WriteLine(e+","+e);
                }
            
        }
    }