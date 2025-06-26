    using System;

public class SinglyLinkedList<T>
{
    public T Value;
    public SinglyLinkedList<T> Next;
    public SinglyLinkedList(T value,SinglyLinkedList<T> next)
    {
        Value=value;
        Next=next;
    }
    
}
public class LinkedList<T>
{ 
    public SinglyLinkedList<T> Head;
    public LinkedList()
    {
        Head=null;
    }    
    public void DeleteHead()
    {
        if(Head==null)
        {
            Console.WriteLine("List is Empty");
        }
        else 
        { 
         Head=Head.Next;
        }
    }
    public void DeleteTail()
    {
         if(Head==null)
        {
            Console.WriteLine("List is Empty");
        }
        else
        {   
          SinglyLinkedList<T> current=Head;
            while(current.Next.Next!=null)
            {
                current=current.Next;
            }
            current.Next=null;
        }
    }
    public void Add(T value)
    {  
        SinglyLinkedList<T> newnode=new SinglyLinkedList<T>(value,null);
        if(Head==null)
        {
            Head=newnode;
        }
        else
        {
            SinglyLinkedList<T> current=Head;
            while(current.Next!=null)
            {
                current=current.Next;
            }
            current.Next=newnode;
        }
    }
    public void Printt()
    {
        if(Head==null)
        {
             Console.WriteLine("List is Empty");
        }
        else
        {
            SinglyLinkedList<T> current=Head;
            Console.WriteLine(current.Value);
            while(current.Next!=null)
            {
                current=current.Next;
                Console.WriteLine(current.Value);
            }
            
        }
    }
    public void RemoveK(int k)
    {
        int count=0;SinglyLinkedList<T> current=Head;
        SinglyLinkedList<T> prev=null;
        if(Head==null)
        {
             Console.WriteLine("List is Empty");
             return;
        }
        else
        {
            while(current!=null)
            {
                count++;
                
                if(count==k)
                {
                    
                   prev.Next=prev.Next.Next;
                }
                
                prev=current;
                current=current.Next;
            }
            return;
        }
    
    }
    public void AddHead(T value)
    {
        SinglyLinkedList<T> newnode=new SinglyLinkedList<T>(value,Head);
        if(Head==null)
        {
        Head=newnode;
        }
        else
        {
            Head=newnode;
        }
    }
     public void AddTail(T value)
    {
   Console.WriteLine("Same As Add");
    }
    public void Addk(int k,T value)
    {  
        int count=0;
        SinglyLinkedList<T> newnode=new SinglyLinkedList<T>(value,null);
        if(Head==null)
        {
           Head=newnode; 
        }
        else if(k==1)
        {
            Head=newnode;
        }
        else
        { SinglyLinkedList<T> current=Head;
            while(current!=null)
            {
                count++;
                
                if(count==k-1)
                {
                    newnode.Next=current.Next;
                    current.Next=newnode;
                }
                current=current.Next;
            }
        }
    }
    public void BeforeVal(T value,int val)
    {
        SinglyLinkedList<T> newnode=new SinglyLinkedList<T>(value,null);
        if (Head==null)
        {
            Head=newnode;
        }
        else
        {
            SinglyLinkedList<T> current=Head;
            while(current.Next!=null)
           {
                 if(current.Next.Value.Equals(val))
               {
                 newnode.Next=current.Next;
                current.Next=newnode;
                return;
                }
                current=current.Next;
            
           }
        }
    }
    public void Delete()
    { 
        
        if(Head==null)
        {
            Console.WriteLine("List is Empty");
        }
        else
        {
            int a=int.Parse(Console.ReadLine());
            SinglyLinkedList<T> current=Head;
            while(current.Next!=null)
            {
                if(current.Next.Value.Equals(a))
                {
                    current.Next=current.Next.Next;
                }
                current=current.Next;
            }
        }

    }  
    public void ArraytoSLL(int []a)
    {
         Head=new SinglyLinkedList<T>(a[0],null);
         SinglyLinkedList<T> Prev=Head;
         for(int i=1;i<a.Length;i++)
        {
        
           SinglyLinkedList<T> temp=new SinglyLinkedList<T>(a[i],null);
           Prev.Next=temp;
           Prev=temp;
        }
            
        
    }
     public bool IsCircularArray()
    {
        Dictionary <SinglyLinkedList<T>,int> dd=new Dictionary <SinglyLinkedList<T>,int>();
        SinglyLinkedList<T> temp=Head;
        while(temp!=null)
        {
            if(dd.ContainsKey(temp))
            return true;
            else
            {
                dd[temp]=1;
            }
            temp=temp.Next;
        }
        return false;
    }
    
    
    
}
public class implement
{
    public static void Main(string [] args)
    {
        LinkedList<int> LL= new  LinkedList<int>();
        LL.Add(10);
        LL.Add(20);
        LL.Add(30);
        LL.Add(40);
        LL.Add(50);
        LL.Add(60);
        LL.DeleteHead();
         LL.DeleteTail();
        LL.RemoveK(3);
        
        LL.AddHead(10);
        LL.Addk(4,40);
        LL.BeforeVal(35,40);
        LL.Printt();
        






we can also write like below... 

        SinglyLinkedList<int> Head=new SinglyLinkedList<int>(10,null);
         Head.Next=new SinglyLinkedList<int>(20,null);
         Head.Next.Next=Head;
         LL.Head=Head;
        // LL.Printt();
        Console.WriteLine(LL.IsCircularArray());
    }
}