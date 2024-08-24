
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler


// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

// public class Contact
// { 
//     public string Name{get;set;}
//     public long Number{get;set;}
//     public Contact(string name,long number)
//     {
//         Name=name;Number=number;
//     }
    
// }
public class ContactList
{
    public static Dictionary<string,long> dicto=new Dictionary<string,long>();
    public static void Main()
    {
    while(true)
    {
    Console.WriteLine("\nSelect your option");
    Console.WriteLine("1.Add new contact");
    Console.WriteLine("2.Update Contact");
    Console.WriteLine("3.Remove Contact");
    Console.WriteLine("4.Search Contact");
    Console.WriteLine("5.Display Contacts");
    
    if(int.TryParse(Console.ReadLine(),out int n))
    {
        switch(n)
        {
            case 1:
            AddContact();
            break;
            case 2:
            UpdateContact();
            break;
            case 3:
            RemoveContact();
            break;
            case 4:
            SearchContact();
            break;
            case 5:
            DisplayContacts();
            break;
        }
    }
    
}
}

static void AddContact()
{
 Console.WriteLine("Enter your name");
 string a= Console.ReadLine();
 Console.WriteLine("Enter your number");
 long b= long.Parse(Console.ReadLine());
 dicto.Add(a,b);
 Console.WriteLine("Contact Added Succesfully");
 
}
static void UpdateContact()
{
    if(dicto.Count>0)
{
    Console.WriteLine("Enter your Contact name to update");
    string c=Console.ReadLine();
    // Contact s=null; 
    if(dicto.ContainsKey(c))
    {  
        Console.WriteLine("Choose Below Options");
       Console.WriteLine("1.Update Name");
        Console.WriteLine("2.Update Number");
        if(int.TryParse(Console.ReadLine(),out int f))
        {
            if(f==1)
            {
        Console.WriteLine("Enter the new name");
        string d=Console.ReadLine();
        long e=dicto[c];
        dicto.Remove(c);
        dicto.Add(d,e);
        Console.WriteLine("Contact name updated Successfully");
        
            }
            else
            {
        Console.WriteLine("Enter the new number");
        long g=long.Parse(Console.ReadLine());
        dicto[c]=g;
        Console.WriteLine("Contact Number updated Successfully");
            }
        }
    }
    else
    {
       Console.WriteLine("Please Enter Valid Keyword"); 
    }
    
}}
static void RemoveContact()
{
    if(dicto.Count>0)
{
    Console.WriteLine("Enter your Contact name to Remove");
    string c=Console.ReadLine();

    if(dicto.ContainsKey(c))
    {
        dicto.Remove(c);
        Console.WriteLine("Contact Removed Successfully"); 
    }
    else
    {
        Console.WriteLine("Please Enter Valid Keyword"); 
    }
}}
static void SearchContact()
{
    if(dicto.Count>0)
{
    Console.WriteLine("Enter your Contact name to Search");
    string c=Console.ReadLine();
foreach(var d in dicto)
    {
        if(dicto.ContainsKey(c))
    {  
        Console.WriteLine($"Contact Name:{d.Key} \nNumber:{d.Value}");
        break;
    }
    else{
      Console.WriteLine("Please Enter Valid Keyword");  
    }}}
    
}
static void DisplayContacts(){
    
//SortedDictionary<string,long> sortedDictionary = new SortedDictionary<string,long>(dicto);
// Create a list of key-value pairs and initialize it with the elements from the dictionary
List<KeyValuePair<string, long>> keyValueList = new List<KeyValuePair<string,long>>(dicto);
keyValueList.Sort(new ValueComparer());
    foreach (var e in keyValueList)
    {
        Console.WriteLine(e.Key+"-"+e.Value);}
    
}

    
}
public class ValueComparer:IComparer<KeyValuePair<string,long>>
{
public int Compare(KeyValuePair<string,long> x,KeyValuePair<string,long> y )
{
    if(x.Value<y.Value)
    return 1;
    else if(x.Value>y.Value)
    return -1;
    else 
    return 0;
    
}
}