 using System;
    using System.Collections.Generic;
    
    public class HelloWorld
    {
        public static void Main(string[] args)
        { 
        Reverse();
         }
         static void Reverse()
         { 
             string a=Console.ReadLine();
             for(int i=a.Length-1;i>=0;i--)
             {
                 Console.Write(a[i]);
             }
         }
    }
