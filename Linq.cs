using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       List<int> num=new List<int>(){1,2,3,4,5,6,7,8,9,10};
     //  var even=from number in num where number%2==0 select number;
       
       var even=num.Where(number=>number%2==0);
       foreach(var e in even)
       {
           Console.WriteLine(e);
       }
    }
}
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string[] a={"Indian 2","Robot","I","Aparichit","Nayak","Robot 2"};
        var d=a.Select(b=>b+"+");
        foreach(var c in d)
        {
            Console.WriteLine(c);
        }
    }
}
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// using System;
// using System.Linq;

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//         string[] a={"Indian 2","Robot","I","Aparichit","Nayak","Robot","Robot"};
//         var d=a.Select(b=>b+"+").Distinct();
//         foreach(var c in d)
//         {
//             Console.WriteLine(c);
//         }
//     }
// }
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// using System;
// using System.Linq;
// using System.Collections.Generic;

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//     List<int> a=new List<int>(){1,2,3,3,4,4,5,4,6};
//         var d=a.Select(b=>b).Distinct();
//         foreach(var c in d)
//         {
//             Console.WriteLine(c);
//         }
//     }
// }
// using System;
// using System.Linq;
// using System.Collections.Generic;

// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
//     Dictionary<int,string> a=new Dictionary<int,string>{{1,"Rakesh"},{2,"Ajay"},{3,"Vikram"},{4,"Ronit"},{5,"Rakesh"}};
//     a=a.OrderBy(b=>b.Value).GroupBy(b=>b.Value).Select(b=>b.First()).ToDictionary(b=>b.Key,b=>b.Value);
//         foreach(var c in a)
//         {
//             Console.WriteLine(c.Key+" "+c.Value);
//         }
//     }
// }
// using System;
// using System.Linq;
// using System.Collections.Generic;

// public class Hello
// {
//     public string FirstName{get;set;}
//     public string LastName{get;set;}
//     public Hello(string fname ,string lastname)
//     {
//         FirstName=fname;LastName=lastname;
//     }
    
    
    
// }
//     public class HelloWorld
// {   
     
//     public static void Main(string[] args)
//     {
//         List<Hello> h=new List<Hello>();
//     Hello h1=new Hello("Rakesh","atil");
//       Hello h2=new Hello ("Rakesh","Pawar");
//       h.Add(h1);h.Add(h2);
//       var i=h.OrderBy(j=>j.FirstName).ThenBy(k=>k.LastName);
//       foreach(var l in i)
//       {
//           Console.WriteLine(l.FirstName+" "+l.LastName);
//       }
//     }
// }
using System;
using System.Linq;
using System.Collections.Generic;


    public class HelloWorld
{   
     
    public static void Main(string[] args)
    {
        List<string> h=new List<string>{"Ramesh","Ritesh","Rajesh","Ronit","Ritesh"};
        Dictionary<string,int> l=new Dictionary<string,int>();
        foreach(var )
     
      var i=h.OrderBy(j=>j).Distinct();
      for(int i=0;i<h.Count();i++)
      {
          for(int j=1;j<h.count();h++)
         if(h[i]==h[j])
         count
      }
    }
}


// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       List<int> num=new List<int>{5,7,1,11,4,99,4,3,99,11};
    //   var no=num.OrderBy(num=>num);
    //  var no=num.OrderByDescending(num=>num).Where(num=>num%2==0);
   // var no=num.Distinct();
       foreach(var n in no)
       {
           Console.WriteLine(n);
       }
    }
}



// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{   
    public string Name{get;set;}
    public int Age{get;set;}
    public HelloWorld(string name,int age)
    {
        Name=name;
        Age=age;
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
    var ho=hh.OrderBy(a=>a.Name).ThenBy(b=>b.Age);
    foreach (var hi in ho)
    {
        Console.WriteLine(hi.Name); //here we have an entity of type <Hello> class so we should always mention .Name;
    }
    }
    
    
    
    
}