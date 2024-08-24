// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class DoublyNode
{
    public object Value;
    
    public DoublyNode Next;
    public DoublyNode Back;
    public DoublyNode(object value,DoublyNode next,DoublyNode back)
    {
        Value=value;
        Next=next;
        Back=back;
    }
    
}
public class DoublyLinkedList
{ 
    public DoublyNode Head;
    
    public DoublyLinkedList()
    {
        Head=null;
    } 
    public DoublyNode ArrayToDLL(int[] arr)
    {
      Head=new DoublyNode(arr[0],null,null);
      DoublyNode prev=Head;
      for(int i=1;i<arr.Length;i++)
      {
          DoublyNode temp=new DoublyNode(arr[i],null,prev);
          prev.Next=temp;
          prev=temp;
      }
     return Head;
    }
    public void Print()
    {
       while(Head!=null)
        {
             Console.WriteLine(Head.Value);
             Head=Head.Next;
         }
    }
    public void DeleteHead()
    {
       DoublyNode prev=Head;
       Head=Head.Next;
       Head.Back=null;
       prev.Next=null;
    }
    public void Deletetail()
    {   DoublyNode current=Head;
         DoublyNode prev=null;
        while(current.Next!=null)
        {  
            current=current.Next;
         }
          prev=current.Back;
          prev.Next=null;
          current.Back=null;
    }
    public void DeleteK(int k)
    {
        DoublyNode current=Head;
        int count=0;
        
        while(current!=null)
        {
            count++;
            if(count==k)
            {break;}
            current=current.Next;
        }
        if(k==1)
        {
            Head=Head.Next;
        }
        else if(current.Next!=null)
        {
            current.Back.Next=current.Next;
     current.Next.Back=current.Back;
        }
    else{
        current.Back.Next=null;
      }
   }
   public void DeleteV(object h)
   { 
       DoublyNode current=Head;
       if(current==null)
       {
           Console.WriteLine("Empty");
       }
       while(current!=null)
       {
           if(current.Back==null ||current.Value.Equals(h))
           {
               current=current.Next;
           }
           else if(current.Next==null ||current.Value.Equals(h))
           {
               current.Back.Next=null;
           }
           else
           {
               current.Back.Next=current.Next;
     current.Next.Back=current.Back;
           }
           current=current.Next;
       }
   }
   public void Insert(object h)
   {   
       DoublyNode temp=new DoublyNode(h,Head,null);
       Head.Back=temp;
       Head=temp;
      
   }
   public void InsertB(object h,int i)
   {
       DoublyNode current=Head;
       if(current==null)
       {
           DoublyNode temp=new DoublyNode(h,null,null);
           Head=temp;
        }
       while(current!=null)
       {
           if(current.Value.Equals(i))
           {
               DoublyNode temp=new DoublyNode(h,current,current.Back);
              
               current.Back.Next=temp;
               temp.Back=current.Back;
               
               
           }
           current=current.Next;
       }
       
   }
}
public class Implement
{ 
    public static void Main(string [] args)
{
    DoublyLinkedList ll=new DoublyLinkedList(); 
    int[] arr={2,10,4,6,8};
     DoublyNode Head=ll.ArrayToDLL(arr);
    //  ll.Print(Head);
    //  ll.DeleteHead();
    //  ll.Deletetail();
    // ll.DeleteK(5);
    // ll.DeleteV(6);
   ll.Insert("Hello");
   
   ll.InsertB("oye",6);
     ll.Print();
}
}
