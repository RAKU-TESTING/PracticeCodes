// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a=370;
        Console.WriteLine(ArmStrong(a));
    }
    static bool ArmStrong(int a)
    { 
        int b=a;int ans=1;int result=0;int d=a;int count=0;
        while(b>0)
        {
            count++;
            b=b/10;
        }
        //  Console.WriteLine(a);
        while(d>0)
        {
            int c=d%10;
            
            for(int i=0;i<count;i++)
            {
                ans=c*ans;
            //   Console.WriteLine(ans);  
            }
            result+=ans;
            ans=1;
            d=d/10;
        }
        
         
        if (result==a)
        {
            return true;
        }
        return false;
    } 
}







// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

d