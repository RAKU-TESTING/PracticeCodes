
// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    { 
     Equal();   
        
    } 
    static bool Equal(){
        bool b=false;
        string a=Console.ReadLine();
        if(int.Parse(a)>99)
        {
          for(int i=0;i<a.Length-2;i++)
       {
        if(a[i]==a[i+1] && a[i+1]==a[i+2])
        {
        //   Console.WriteLine("ok");
          b=true;
          break;
        }
        
      }
      if(b){
          Console.WriteLine("equal");
      }
      else
      {
      Console.WriteLine("not equal");
      }
      }
      else 
      {
        Console.WriteLine("please Enter three Digit value");
        }
      return b;
    
}}
    
