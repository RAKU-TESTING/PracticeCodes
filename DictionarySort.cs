// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld:IComparable<HelloWorld>
{
    public string Name{get; private set;}
    public int Age{get;private set;}
    public HelloWorld(string name,int age)                                                           
    {
        Name=name;
        Age=age;
    }
    public int CompareTo(HelloWorld other)
    {
        return this.Name.CompareTo(other.Name);
        
    }
     
}
public class Hello
{
    public static void Main()
    {
        List<HelloWorld> hh=new List<HelloWorld>();
    HelloWorld h=new HelloWorld("Rakesh",31);
    HelloWorld h1=new HelloWorld("Ajay",24);
    HelloWorld h2=new HelloWorld("Kishor",29);
    HelloWorld h3=new HelloWorld("Ronit",22);
     HelloWorld h4=new HelloWorld("Ronit",21);
    hh.Add(h);hh.Add(h1);hh.Add(h2);hh.Add(h3);hh.Add(h4);
    // var ho=hh.OrderBy(a=>a.Name).ThenBy(b=>b.Age);
    hh.Sort();
    foreach (var hi in hh)
    {
        Console.WriteLine(hi.Name); //here we have an entity of type <Hello> class so we should always mention .Name;
    }
    }
    
    
    
    
}