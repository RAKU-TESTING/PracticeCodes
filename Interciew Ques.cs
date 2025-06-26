// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
using System.Linq;

public struct HelloWorld
{                                                   
     public string Name;
     public int RollNo;
     public int Age;
     public string Gender;
   
    public HelloWorld(string name,int rollno,int age,string gender)
    {
       Name=name;RollNo=rollno;Age=age;Gender=gender;
    }
    //  public void Display()
    // {
    //     Console.WriteLine($"Name: {Name}, RollNo: {RollNo}, Age: {Age}, Gender: {Gender}");
    // }
}
class Hello
{
    public static void Main()
    {
        List<HelloWorld>i=new List<HelloWorld>();
        HelloWorld h=new HelloWorld("Rakesh",11,16,"Male");
        HelloWorld h1=new HelloWorld("Ritesh",12,16,"Male");
        HelloWorld h2=new HelloWorld("Ronit",13,15,"Male");
        HelloWorld h3=new HelloWorld("Radha",14,16,"Female");
        i.Add(h);i.Add(h1);i.Add(h2);i.Add(h3);
        var d=i.Select(f=>f.Name).OrderBy(name=>name);//after Selecting only name you can direcly sort as int
        foreach(var g in d)
        {
            Console.WriteLine(g.ToUpper());
        }
}}  

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      var c=Yess();
      Console.WriteLine(c);
    }
    public static object Yess()
    { 
        int n;
        int result=0;
        if(int.TryParse(Console.ReadLine(),out n))
        {
         return (n*50)+6;
        }
        else {
            return "Error";
        }
        
    }
}