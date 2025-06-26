// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public class MyException:Exception//thsi is Important Read In notebook
{
    public MyException(string message):base(message){}
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        HelloWorld h=new HelloWorld();
        try
        {
            h.CheckAge(17);
        }
        catch(ArgumentException )
        {
            Console.WriteLine("Please enter valid age");
        }
        // catch(Exception ex)
        // {
        //     Console.WriteLine(ex.Message);
        // }
    }
    public void CheckAge(int age )
    {
        if(age<18)
        {
            throw new MyException("Age must be above 18");
        }
        else
        {
            Console.WriteLine("it is valid");
        }
    }
    
    
}l