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