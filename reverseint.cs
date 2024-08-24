using System;
    
    public class HelloWorld
    {
        public static void Main(string[] args)
        { 
         int a=int.Parse(Console.ReadLine());
         int r=0;
    
    
            while(a>0)
            {
                int digit =a%10;
                r=r*10+digit;
                a=a/10;
            }
            Console.WriteLine(r);
        }
        
    }
