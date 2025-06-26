using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string a="srk";
        int index=0;
        Reverse(a,index);
    }
    static void Reverse(string a,int index)
    { if(index==a.Length){
        return ;
    }
       
        Reverse(a,index+1);
         Console.WriteLine(a[index]);
        
    }
    
}//which approach is better this or  aproach?
