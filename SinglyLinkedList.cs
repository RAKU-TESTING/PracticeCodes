// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class SinglyNode<T>
{
   public T Value;
   public SinglyNode<T> Next;
   
   public SinglyNode(T value,SinglyNode<T> next)
   {
       Value=value;
       Next=next;
   } 
}
public class LinkedList<T>
{
    public SinglyNode<T> Head;
    public LinkedList()
    {
        Head=null;
    }
    public T Add(T value)
    {   
        SinglyNode<T> newnode=new SinglyNode<T>(value,null);
        
        if(Head==null)
        {
            Head=newnode;
        }
        else
        {
            SinglyNode<T> current=Head;
            while(current.Next!=null)
            {
                current=current.Next;
            }
            current.Next=newnode;
        }
        return value;
    }
    
    public T Remove(T value)
    {
        if(Head==null)
        {
            Console.WriteLine("List is Empty");
        }
        else
        {
            SinglyNode<T> current=Head;
            while(current.Next!=null)
            {
                if(current.Next.Value.Equals(value))
            {
                current.Next=current.Next.Next;
                
            }
               current=current.Next;            
           }
          
        } return value;
    }
   
}
public class yess
{
    public static void Main(string []args)
    {
        LinkedList<int> lower=new LinkedList<int>();
        Console.WriteLine(lower.Add(10));
        Console.WriteLine(lower.Add(20));
        Console.WriteLine(lower.Add(30));
      Console.WriteLine(lower.Remove(20));
    //     foreach(int r in lower)
    //     {
    //         Console.WriteLine(r.Value);
    //     }
        
    }
}