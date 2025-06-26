// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;


public class Contact
{
   public string _Name{get; set;}
   public long _Number{get; set;}
 public Contact(string name,long number)
 {
     _Name=name;
     _Number=number;
}
}
public class Contactmanager
{ 
   public List<Contact> co =new List<Contact>();
   
    public static void Main(string []args)
    {  
        Contactmanager h=new Contactmanager();
    while (true)
    {
    Console.WriteLine("\nSelect the process");
    Console.WriteLine("1.Add Contact: ");
    Console.WriteLine("2.Update Contact: ");
    Console.WriteLine("3.Delete Contact: ");
    Console.WriteLine("4.Display Conatct: ");
    int n;
    
    Console.WriteLine("\nEnter the Choice number");
    if(int.TryParse(Console.ReadLine(),out n))
    {
        if(n==1)
        { h.ADDCONTACT();}
        else if(n==2)
        { h.UPDATECONTACT();}
        else if(n==3)
        {h.DELETECONTACT();}
        else if(n==4)
        {h.DISPLAYCONTACT();}
        
    }
    }
    }
    void ADDCONTACT()
    {
        Console.WriteLine("Enter the Name:");
        string name=Console.ReadLine();
        
        Console.WriteLine("Enter the number");
        string n=Console.ReadLine();
        long num=long.Parse(n);

        co.Add(new Contact(name,num));
          Console.WriteLine("Number Added Succesfully");
        
    }
    void UPDATECONTACT()
    {
        Console.WriteLine("Enter the Name you want to edit");
        string name=Console.ReadLine();
        // Contact cont=null;
     
    //  var ac=co.FirstOrDefault(a=>a._Name.Equals(name, StringComparison.OrdinalIgnoreCase));
     var ac=co.FirstOrDefault(a=>a._Name==name);
    //  Console.WriteLine(ac._Name+"-"+ac._Number);
     if(ac!=null)
     { Console.WriteLine(ac._Name+"-"+ac._Number);}
     else
     {Console.WriteLine("Not found");}
    //     foreach (Contact c in co)
    //     {
    //         if (c._Name.Equals(name, StringComparison.OrdinalIgnoreCase))
    //         {
    //             cont = c;
    //             break;
    //         }
    //     }
    //     if(cont!=null)
    //     {
    //         Console.WriteLine("Enter the new name and left empty  if You dont want to edit");
    //         string newname =Console.ReadLine();
    //         Console.WriteLine("Enter the new number and left empty  if You dont want to edit");
    //         string ne= Console.ReadLine();
    //         long newnum =long.Parse(ne);
            
    //         if(!string.IsNullOrWhiteSpace(newname))
    //         {
    //             cont._Name = newname;
    //         }
    //         if(!string.IsNullOrWhiteSpace(ne))
    //         {
    //             cont._Number = newnum;
    //         }
    //         else
    //         {
    //             Console.WriteLine("Invalid Number format ..keeping number unchanged");
    //         }
            
    //     }
    //     else 
    //     {
    //     Console.WriteLine("Contact not Found");    
    //     }
     }
    
void DELETECONTACT()
{
          Console.WriteLine("Enter the Name you want to Delete");
        string name=Console.ReadLine();
        Contact cont=null;
       
        foreach (var c in co)
        {
            if (c._Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                cont = c;
                break;
            }
        }
        if(cont!=null)
        {
            co.Remove(cont);
            Console.WriteLine("Deleted Contact Successfully");
            
        }
        else
        {
            Console.WriteLine("Contact not found");
        }
}

void DISPLAYCONTACT()
{
    co=co.DistinctBy(a=>a._Name).ToList();
    if(co.Count>0){
    foreach (var cc in co)
    {
        Console.WriteLine("Contact List:");
     //   Console.WriteLine($"{cc._Name} - {cc._Number}");
        Console.WriteLine(cc._Name+"-"+cc._Number);
    }
}
else{
    Console.WriteLine("Contact is Empty");
}
}}    
        
