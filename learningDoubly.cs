// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class DoublyNode<T>
{
     public  T Value;
     public DoublyNode<T> Next;
     public DoublyNode<T> Prev;
     
     public DoublyNode(T value,DoublyNode<T> next,DoublyNode<T> prev)
     {
         Value=value;
         Next=null;
         Prev=null;
     }
     
}
public class DoublyLinkedList<T>
{
    public DoublyNode<T> Head;
    public DoublyLinkedList()
    {
        Head=null;
    }
    public void DeleteHead()
    {  
        Head=Head.Next;
        Head.Prev=null;
    
        
    }
    public void DeleteTail()
    {  
      DoublyNode<T> current=Head;
      while (current.Next.Next!=null)
      {
          current=current.Next;
      }
    current.Next=null;
        
    }
    public void Deletetail()
    {  
      DoublyNode<T> current=Head;
      while (current.Next!=null)
      {
          if(current.Next.Next==null)
          {
             
              current.Next=null;
              return;
          }
          current=current.Next;
          
      }
    }
    public void DeleteK(int k)
    {
        int count=0;
        DoublyNode<T> current=Head;
        while(current.Next!=null)
        {
            count++;
            if(count==k-1)
            {
                current.Next=current.Next.Next;
                current.Next.Prev=current;
            }
            current=current.Next;
        }
        
    }
    public void Delete(T value)
    {
        DoublyNode<T> current=Head;
        while(current.Next!=null)
        {
            if(current.Next.Value.Equals(value))
            {
                current.Next=current.Next.Next;
                current.Next.Prev=current;
                return;
            }
            current=current.Next;
        }
        
    }
    public void Addv(T value,int k)
    { 
       
        int count=0;
        DoublyNode<T> current=Head;
        while(current!=null)
        { 
            count++;
            if(count==k-1)
            {    DoublyNode<T> newnode=new  DoublyNode<T>(value,current.Next,current);
                
               
                current.Next=newnode;
                current.Next.Prev=newnode;
              
             }
            current=current.Next;
        }
        
    }
    public void Add(T value)
    { 
       DoublyNode<T> newnode=new DoublyNode<T>(value,null,null);
        
        if(Head==null)
        {
            Head=newnode;
        }
        else
        {
            DoublyNode<T> current=Head;
            while(current.Next!=null)
            {
                current=current.Next;
            }
            current.Next=newnode;
            newnode.Prev=current;
        }
    }
    public void Printt()
    {
        DoublyNode<T> current=Head;
         while(current!=null)
         {
             Console.WriteLine(current.Value);
             current=current.Next;
         }
        
    }
    }
    
      public class implement
 {
    public static void Main(string [] args)
    {
        DoublyLinkedList<int> LL= new  DoublyLinkedList<int>();
        LL.Add(10);
        LL.Add(20);
        LL.Add(30);
        LL.Add(40);
        // LL.Deletetail();
        // LL.Delete(30);
        LL.Addv(50,2);
        LL.Printt();
        
        
    }
}