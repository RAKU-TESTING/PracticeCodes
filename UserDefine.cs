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





using System;

public class Student
{
  public string Name;
  public int RollNo;
  public int Physics;
  public int Chemistry;
  public int Math;
  public Student(string name,int rollno,int physics,int chemistry,int math)
  {
      Name=name;RollNo=rollno;Physics=physics;Chemistry=chemistry;Math=math;
  }
  public void Display()
  {
      Console.WriteLine(Name+" "+"Rollno-"+" "+RollNo);
      Console.WriteLine("Physics-"+Physics);
      Console.WriteLine("Chemistry"+Chemistry);
       Console.WriteLine("Math"+Math);
  }
}
public class Read
{
    public static void Main()
    {
        Student one=new Student("Rakesh",01,50,70,78);
        Student two=new Student("Kishor",02,60,60,60);
        one.Display();
    }
}