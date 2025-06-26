// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int[] arr1={1,2,3,4,5};
      int[]arr2={2,3,4,4,5};
      int[] common=new int[arr1.Length];
      int[] one=new int[arr1.Length];
      int[] two=new int[arr2.Length];
      int []union=new int [arr1.Length+arr2.Length];
      int indexone=0;
      int indexcommon=0;
      int indextwo=0;
      bool a=false;
      bool b=false;
      int Unionindex=0;
      
      for(int i=0;i<arr1.Length;i++)
      {
          for(int j=0;j<arr2.Length;j++)
          {  a=false;
              if(arr1[i]==arr2[j])
              {
                  common[indexcommon]=arr1[i];
                  indexcommon++;
                  union[Unionindex]=arr1[i];
                  Unionindex++;
                  a=true;
                  break;
              }
          }
          if (!a)
          {
        one[indexone++] = arr1[i];
        union[Unionindex++]=arr1[i];
          }
      }
      for(int k=0;k<arr2.Length;k++)
      { b=false;
          for(int l=0;l<common.Length;l++)
          {
              if(arr2[k]==common[l])
              {
                 b=true;
                  break;
              }
          }
          if(!b)
          { 
              two[indextwo]=arr2[k];
                  indextwo++;
                 union[Unionindex]=arr2[k];
                 Unionindex++;
              
          }
          
      }
    //   foreach(var ans in common)
    //   {if(ans!=0){
    //       Console.WriteLine(ans);
    //   }}
    //   foreach(var ans in one)
    //   {if(ans!=0){
    //       Console.WriteLine(ans);
    //   }}
    //   foreach(var ans in two)
    //   {if(ans!=0){
    //       Console.WriteLine(ans);
    //   }}
      
     Array.Sort(union);
      foreach(var ans in union)
      {if(ans!=0){
          Console.WriteLine(ans);
      }
    }}
    
}





using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
      int[] arr1={1,2,3,4,5};
      int[]arr2={2,3,4,4,5};
      HashSet<int> S=new HashSet<int>(arr1);
     foreach(int b in arr2)
     {
         S.Add(b);
     }
    
     foreach (var c in S)
     {
         Console.WriteLine(c);
     }
    }
}