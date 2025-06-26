// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler


using System;
using System.Collections.Generic;


public class DoublyNode
{
   public object Value;
   public DoublyNode Next;
   public DoublyNode Prev;
   public DoublyNode(object value,DoublyNode next,DoublyNode prev)
   {
       Value=value;
       Next=next;
       Prev=prev;
   }
 }
 
 public class DoublyList
 {
    public DoublyNode Head;
    public DoublyList()
    {
        Head=null;
    }
    public void Add(object a)
    {
        DoublyNode newnode=new DoublyNode(a,null,null);
        if(Head==null)
        {
            Head=newnode;
        }
        else
        {
            DoublyNode current=Head;
            while(current.Next!=null)
            {
                current=current.Next;
            }
        current.Next=newnode;
        newnode.Prev = current;
        }
    }
    public void AddHead(object a)
    {
        DoublyNode newnode=new DoublyNode(a,Head,null);
        if(Head==null)
        {
            Head=newnode;
        }
        else
        {
            // Head.Prev=newnode;
            Head=newnode;
        }
        
    }
    public void DeleteTail()
    {
        if(Head==null)
        {
           Console.WriteLine("Empty");
        }
        else
        {
             DoublyNode current=Head;
             while(current.Next.Next!=null)
            {
              current=current.Next;
            }
            current.Next=null;
        }
        
    }
    public void Display()
    {
        if(Head==null)
        {
            Console.WriteLine("It is Empty");
        }
        else
        {
            DoublyNode current=Head;
              while(current!=null)
            {
                Console.WriteLine(current.Value);
                current=current.Next;
             }
            
        }
        
    }
    public void ReverseByStackMethod()
    {
       Stack<object>  pile= new Stack<object>();
         if(Head==null)
        {
            Console.WriteLine("It is Empty");
        }
        else
        {
             DoublyNode current=Head;
           while(current!=null)
           { 
               pile.Push(current.Value);
               current=current.Next;
           }
           DoublyNode r=Head;
           while(r!=null)
           { 
              r.Value=pile.Pop();
               r=r.Next;
           }
        //   foreach(var o in pile)
        //   {
        //       Console.WriteLine(o);
        //   }
        }
        }
        public DoublyNode ReverseByiterative()
        {
             DoublyNode last=null;
             if(Head==null)
        {
            Console.WriteLine("It is Empty");
        }
        else
        {
             DoublyNode current=Head;
            
            
             while(current!=null)
             {
                 last=current.Prev;
                 current.Prev=current.Next;
                 current.Next=last;
                 current=current.Prev;
                 
             }
             if(last!=null)
             {
                 Head=last.Prev;
             }
           
        //   DoublyNode rr=Head;
           
        //       while(rr!=null)
        //     {
        //         Console.WriteLine(rr.Value);
        //         rr=rr.Next;
        //      }
           
        }
        
           return Head; 
        }
    public static void Main(string []args)
    {
        DoublyList d=new DoublyList();
         d.Add(10);
         d.Add(20);
         d.Add("Rakesh");
         d.Add(40);
        //  d.Add(false);
        //  d.AddHead(25);
        //  d.AddHead(30);
        //   d.DeleteTail();
        //  d.Display();
         
         d.ReverseByiterative();
        d.Display();
    }    
    }
 