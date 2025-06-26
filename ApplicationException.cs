
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Check();
    }
    public static void Check()
    {
          Console.WriteLine("Enter First number For Division");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number For Division");
            int b=int.Parse(Console.ReadLine());
            if(b%2!=0)
            {
                throw new ApplicationException("NOOOO");
                //throw new rr.DivideByOddNumberException();
            }
            else
             {
                 int c=a/b;
                 Console.WriteLine(c);
                 
             }
             
    }}
    namespace rr{
    public class  DivideByOddNumberException:ApplicationException
    {
        public override string Message{
            get
        {
        return "Atempted to divide by odd number";
        }
    }}
        
            
}