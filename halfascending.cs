    // Online C# Editor for free
    // Write, Edit and Run your C# code using C# Online Compiler
    
    using System;
    using System.Collections.Generic;
    
    public class HelloWorld
    {   public static void Main(string []args)
         {
        string a=Console.ReadLine();
        string[] b=a.Split(',');
       
           int[] d=new int[b.Length];
           for(int i=0;i<b.Length;i++)
           {
            d[i]=int.Parse(b[i]);
           }
           int k=b.Length/2;
           int l=0;
           for(int j=0;j<k;j++)
           { 
               for(int o=j+1;o<k;o++)
              {
                  if(d[j]>d[o])
               {
                   l=d[j];
               d[j]=d[o];
               d[o]=l;
               }}
          }
          int m=0;
           for(int n=k;n<b.Length-1;n++)
           {   
                for(int f=k+1;f<b.Length;f++)
              {
                  if(d[n]<d[f])
               { 
                   m=d[n];
               d[n]=d[f];
               d[f]=m;
               }
        }}
        foreach(var e in d)
        { Console.Write(e+",");}
         }
}