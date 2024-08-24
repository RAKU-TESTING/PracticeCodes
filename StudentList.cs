// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class Person
{
    
    public string FirstName{get;set;}
    public string LastName{get;set;}
    
}
public class Student:Person
{    
    
 public int StudentID{get;set;} 
 public double GPA{get;set;}
  
  public Student(int id,string fname,string lastname,double gpa)
  {
      StudentID = id;
      GPA = gpa;
      FirstName =fname;
      LastName =lastname;
  }
 
 public static List<Student> s=new List<Student>();

public static void Main(string []args)
{                                
    Console.WriteLine("Student Manage System:");
    while(true)
    {
       
        Console.WriteLine("\n1.Add New Student");
        Console.WriteLine("2.Display All Students ");
        Console.WriteLine("3.Find Student");
        Console.WriteLine("4.Update Student Details");
        Console.WriteLine("5.Delete ");
        Console.WriteLine("Enter the Choice");
        if(int.TryParse(Console.ReadLine(),out int n))
        {
            if(n==1)
            {
     AddStudent();
            }
            else if(n==2)
            {
        DisplayStudent();
            } 
            else if(n==3)
            {
     FindStudent();
            }
            else if(n==4)
            {
        Update();
            }
            else if(n==5)
            {
        Delete();
            }
        }
        else
         Console.WriteLine("Please enter valid id")};
            
        }
    }
}

 public static void AddStudent()
{
    
    Console.WriteLine("Enter the First name");
    string f=Console.ReadLine();
    Console.WriteLine("Enter the Last name");
    string l=Console.ReadLine();
    Console.WriteLine("Enter the ID");
    // int i=int.Parse(Console.ReadLine());
    if(int.
    Console.WriteLine("Enter the GPA");
    double d=double.Parse(Console.ReadLine());
    
 Student s1=new Student(i,f,l,d);
 s.Add(s1);
 Console.WriteLine("Added Successfully");
 
}
public static void  DisplayStudent()
{
    if(s.Count>0)
    {
   foreach(var w in s )
   {
    Console.WriteLine(w.StudentID+"."+w.FirstName+" "+w.LastName+"-"+w.GPA);
    }
    
}
else
{
    Console.WriteLine("List is empty");}}
public static void  FindStudent()
{
    Console.WriteLine("Enter the Studend id you Want yo Find");
   int a=int.Parse(Console.ReadLine());
  Student c=null;
   foreach (var b in s)
   {
       if(b.StudentID==a)
       {
           c=b;
        }
       else 
       {
          Console.WriteLine("please enter valid Id"); 
        }
       
   }
   if(c!=null)
   {
       Console.WriteLine("Your Students Details is ");
       Console.WriteLine(c.StudentID+"."+c.FirstName+" "+c.LastName+"-"+c.GPA);
   }
}
public static void Update()
{
    Console.WriteLine("Enter the Studend id you Want to Update");
   int a=int.Parse(Console.ReadLine());
  Student c=null;
   foreach (var b in s)
   {
       if(b.StudentID==a)
       {
           c=b;
        }
       else 
       {
          Console.WriteLine("please enter valid Id"); 
        }
       
   }
   if(c!=null)
   {
    Console.WriteLine("Enter the First name you want to update");
    string l=Console.ReadLine();
    Console.WriteLine("Enter the Last name you want to update");
    string m=Console.ReadLine();
    Console.WriteLine("Enter the GPA you want to update");
    double d=double.Parse(Console.ReadLine());
    
    c.FirstName =l;c.LastName = m;c.GPA=d;
    Console.WriteLine("Your updated details are as follows");
    Console.WriteLine(c.StudentID+"."+c.FirstName+" "+c.LastName+"-"+c.GPA);
}}
public static void Delete()
{
    Console.WriteLine("Enter the Studend id you Want to Delete");
   int a=int.Parse(Console.ReadLine());
  Student c=null;
   foreach (var b in s)
   {
       if(b.StudentID==a)
       {
           c=b;
        }
       else 
       {
          Console.WriteLine("please enter valid Id"); 
        }
       
   }
   if(c!=null)
   {
       s.Remove(c);
       Console.WriteLine("Deleted Successfully ");
    }
    
}