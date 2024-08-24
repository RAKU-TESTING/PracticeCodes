    
    using System;
    using System.Collections.Generic;
    
    public class HelloWorld
    {
        public static void Main(string[] args)
        { 
         Dictionary <char,int> d=new Dictionary <char,int>();
         string a=Console.ReadLine();
         foreach(char b in a)
         { 
             if(d.ContainsKey(b))
            { d[b]++;}
            else
            {
                d[b]=1;
            }
         }
         foreach(var e in d)
         {
             Console.WriteLine(e.Key+"-"+e.Value);
         }
        
    }
    }