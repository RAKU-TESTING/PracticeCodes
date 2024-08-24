// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
   public static Dictionary <string,int> p=new Dictionary <string,int>();
    public static void Main(string[] args)
    {
        
        
        while (true)
        {   Console.WriteLine("\nInventory ManageMent");
            Console.WriteLine("1.Add new item in inventory");
            Console.WriteLine("2.Update the Quantity of item");
            Console.WriteLine("3.Remove Item from Inventory");
            Console.WriteLine("4.Check quantity of each item");
         
            
          
            
           if(int.TryParse(Console.ReadLine(),out int n))
           {
               if(n==1)
             Additem();
             else if(n==2)
              Update();
           
              else if(n==3)
               Remove();
               else if(n==4)
               Check();
           }
           
        }
    }
    static void Additem()
    { 
        Console.WriteLine("Enter the item");
      string a=Console.ReadLine();
      int b=int.Parse(Console.ReadLine());
      
      p.Add(a,b);
       Console.WriteLine("item added Successfully");
    }
    static void Update()
    {
        Console.WriteLine("Enter the item you want to update");
        string a= Console.ReadLine();
        
        if(p.ContainsKey(a))
        { int b= int.Parse(Console.ReadLine());
          p[a]=p[a]+b;
          Console.WriteLine("Quantity Updated successfully");
        }
        else
        {
            Console.WriteLine("Item not Exist");
            return;
        }
    }
    static void Check()
    {
        foreach(var c in p)
       {
           Console.WriteLine(c.Key+"-"+c.Value);
       }
    }
    static void Remove()
    {
         Console.WriteLine("Enter the item you want to Remove ");
        string a= Console.ReadLine();
        
        if(p.ContainsKey(a))
        {
            p.Remove(a);
            Console.WriteLine("Removed Successfully");
        }
        
    }
}
      
      
      