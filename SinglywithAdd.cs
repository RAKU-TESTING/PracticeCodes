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
    public int count;
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
    public void DeleteHead()
    { 
      if(Head==null)
      {
          Console.WriteLine("Empty");
      }
      else
{       Head=Head.Next;}
        
    }
    public void Printt()
    { 
      if(Head==null)
      {
          Console.WriteLine("Empty");
      }
      else
     {
            SinglyNode<T> current=Head;
            Console.WriteLine(current.Value);
            while(current.Next!=null)
            {
                current=current.Next;
                Console.WriteLine(current.Value);
            }
            
        }
        
    }}
    public class yess
{
    public static void Main(string []args)
    {
        LinkedList<int> lower=new LinkedList<int>();
        lower.Add(10);
        lower.Add(20);
        lower.Add(30);
        lower.DeleteHead();
        lower.Printt();
        
    }}