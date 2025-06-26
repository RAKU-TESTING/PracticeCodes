// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   HelloWorld h=new HelloWorld();
        try
        {
            int[] input={1,2,3,4};
            
            int[] c=h.Check(input);
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex1)
        {
            Console.WriteLine(ex1.Message);
        }
    }
    public int[] Check(int[] a)
    {
        foreach (int b in a)
        {
            if(b==1)
            {
                throw new IndexOutOfRangeException("Value 1 is not allowed");
            }
            
        }
        return a;
    }
    
    
}