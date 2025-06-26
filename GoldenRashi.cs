// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    { 
    //   bool yes=int.TryParse(Console.ReadLine(),out int a);
    //   if(!yes)
    //   {
    //       Console.WriteLine("Please Enter Valid Digits ");
    //   }
      Combinations(4);
     
      
    }
    public static void Combinations(int a)
    { 
        Dictionary <string,int> comb=new Dictionary<string,int>(StringComparer.OrdinalIgnoreCase);
        Dictionary <string,int> result=new Dictionary<string,int>();
        string[] b={"MES","VRI","MIT","KAR","SIM","KAN","TUL","VRCH","DHA","MAK","KUM","MEE"};
        foreach(var Key in b)
        {
          comb.Add(Key,0);
          result.Add(Key,0);
          Console.WriteLine(Key);
          
        }
        while(true)
        {
         Console.WriteLine("Select Your Rashi");
         
        Console.WriteLine("\n");
        string d=Console.ReadLine();
        int max=(int)Math.Pow(10,a)-1;
        Console.WriteLine("Enter the 4 Digit Code");
        int value=int.Parse(Console.ReadLine());  
        
        if(value<max && value>0)
        {
          if(comb.ContainsKey(d))
          { 
              comb[d]=value;
              Console.WriteLine(d+"-"+comb[d].ToString("0000"));
              
          }
            
        }
    // Console.WriteLine(comb.Count);
        Console.WriteLine("Would you like to add More Bet Type Y/N");
        string choice=Console.ReadLine();
        var random = new Random();
         
        int randomindex=random.Next(b.Length);
        // Console.WriteLine(b[randomindex]);
         int randomNumber = random.Next(0000, 10000); // Note: upper bound is exclusive

        // Print the random number
        // Console.WriteLine("Random 4-Digit Number: " + randomNumber);
        if(choice.Equals("N", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine(b[randomindex]+"-"+randomNumber);
            
            return;
        }
      
        
      }
        
    }
}