using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
     string[] a={"Ronit","Rakesh","Ajay","Ritesh","Vikram","Kishor","Ajay sir","Akshay","Akash","sandeep" };
     string c=Console.ReadLine();
     bool yes=false;
     foreach(var b in a)
    //  { string sub=b.Substring(0,3);
    //      if(sub.Contains(c))    //by this you can Achieve this we save substring and compare it
         if(b.Contains(c, StringComparison.OrdinalIgnoreCase))//in this if we search A it will find All names Consist of a;
         {    yes=true;
             Console.WriteLine(b);
         }
       
}
if(!yes)
{
    Console.WriteLine("please enter valid input");
        
}
}}