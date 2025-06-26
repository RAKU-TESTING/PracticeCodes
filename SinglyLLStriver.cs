using System;

public class SinglyNode
{
    public object Value;
    public SinglyNode Next;
    public SinglyNode(object value,SinglyNode next)
    {
        Value=value;
        Next =next;
    }
}
public class SinglyList
{
    public SinglyNode Head;
    public SinglyList()
    {
        Head=null;
    }
    public void AddNode(object a)
    {
        SinglyNode newnode=new SinglyNode(a,null);
       
        if(Head==null)
        {
            Head=newnode;
        }
        else
        {
             SinglyNode Current=Head;
           while(Current.Next!=null)
           {
            Current=Current.Next;
           }
           Current.Next=newnode;
        }
    }
    public void AddHead(object a)
    {
        SinglyNode newnode=new SinglyNode(a,Head);
         if(Head==null)
        {
            Head=newnode;
        }
        else
        {
             Head=newnode;
        }
    }
    public void DeleteLast()
    {
         if(Head==null)
        {
            Console.WriteLine("empty");
        }
        else
        { 
            SinglyNode Current=Head;
           while(Current.Next.Next!=null)
           {
            Current=Current.Next;
           }
           Current.Next=null;
        }
        
    }
    public int Length()
    {  int count=0; 
        if(Head==null)
        {
            return 0;
        }
        else
        { 
            SinglyNode Current=Head;
           while(Current!=null)
           {
            Current=Current.Next;
            count++;
           }
          
        }
        return count;
    }
    public bool Search(object a)
    {
       SinglyNode Current=Head;
             while(Current!=null)
           {
              if(Current.Value.Equals(a))
              {
                  return true;
                  
              }
     Current=Current.Next;
             
           }
           return false;
   } 
    public  void Display()
    {
        if(Head==null)
        {
            Console.WriteLine("Empty");
        }
        else
        {
            SinglyNode Current=Head;
             while(Current!=null)
           {
              Console.WriteLine(Current.Value);
            Current=Current.Next;
             
           }
            
        }
        
    }
     public  static void Main(string[] args)
    {    
        SinglyList a=new SinglyList();
        a.AddNode(10);
        a.AddNode("Rakesh");
        a.AddNode(30);
        a.AddNode(40);
        // a.AddHead(50);
        a.AddHead(70);
        // a.DeleteLast();
        // Console.WriteLine(a.Length());
        // Console.WriteLine(a.Search(50));
         a.Display();
    }
   
    
}
