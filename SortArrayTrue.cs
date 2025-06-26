// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
     int [] a={5,3,2,1,1};
     Console.WriteLine(SortCheck(a));
     
    }
    static bool SortCheck(int []a)
    {
        int temp=a[0]-a[1];
        int index=0;
        if(temp==0)
        {
            while(temp==0)
            {
                temp=a[index]-a[index+1];
                index++;
            }
        
        }
        for(int i=0;i<a.Length-1;i++)
        { 
            if(temp<0)
          {
             if((a[i]-a[i+1])>0)
            {
                return false;
            }
         }
         if(temp>0)
         {
             if((a[i]-a[i+1])<0)
             {
                 return false;
             }
        }
        }
        return true;
        
       }}