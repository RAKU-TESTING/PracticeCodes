// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

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
     public void Display()
    {
        Console.WriteLine($"Name: {Name}, RollNo: {RollNo}, Age: {Age}, Gender: {Gender}");
    }
}
class Hello
{
    public static void Main()
    {
        HelloWorld h=new HelloWorld("Rakesh",11,16,"Male");
        HelloWorld h1=new HelloWorld("Ritesh",12,16,"Male");
        HelloWorld h2=new HelloWorld("Ronit",13,15,"Male");
        HelloWorld h3=new HelloWorld("Radha",14,16,"Female");
        h.Display();
        h1.Display();
        h2.Display();
        h3.Display();
}}