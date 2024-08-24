
using System;
using System.Collections.Generic;


public class BankAt
{  
    private static int accnos=1000;
    public string _Name{get;set;}
    public int _AccNo {get;}
    public int _Bal{get;set;}
    
    public BankAt(string name,int bal)
    {
        _Name=name;
        _AccNo=accnos++;
        _Bal =bal;
        
    }
}    
    
public class BankDetails
{    
     public List<BankAt> c=new List<BankAt>();
    public static void Main(string[] args)
    {  
        BankDetails b = new BankDetails();
     
       while (true)
       {
           Console.WriteLine("\nSelect your Choice");
           Console.WriteLine("1.Create Account");
           Console.WriteLine("2.Deposite");
           Console.WriteLine("3.Withdraw");
           Console.WriteLine("4.Balance Check");
           Console.WriteLine("5.Account Details");
           int n;
           Console.WriteLine("\nEnter your Choice");
           if(int.TryParse(Console.ReadLine(),out n))
           {
               if(n==1)
               {
                    b.CreateAcc();
                }
               else if(n==2)
               {
                   b.Deposite();
               }
               else if(n==3)
               {
                   b.Withdraw();
               }
               else if(n==4)
               {
                    b.BalanceCh(); 
               }
               else if(n==5)
               {
                   b.AccountDet();
               }               
               
           }
           
       }
    }
    void CreateAcc()
    {
       Console.WriteLine("Enter the Account holder Name");
       string name=Console.ReadLine();
       foreach(char s in name)
       {
       if(!char.IsDigit(s))
       {
        Console.WriteLine("Enter the Deposite");
        int d=int.Parse(Console.ReadLine());
        
        if(d>=1000)
        {
        BankAt newacc=new BankAt(name,d);
        c.Add(newacc);
        Console.WriteLine("Account Created Successfully");
        Console.WriteLine("Your Account number is "+" "+newacc._AccNo);
        }
         else
        {
            Console.WriteLine("Minimum  Rs.1000 is Required");
            
        }
       }
       else
       {
            Console.WriteLine("Enter Valid name");
            break;
        }
}}
     void Deposite()
     {  
         Console.WriteLine("Enter the account number");
         int acno=int.Parse(Console.ReadLine());
        
         BankAt acc=null;
          foreach (var f in c)
        {
          if(f._AccNo==acno)
          {
         acc=f;
         break;
        }
        }
     
      if(acc!=null)
      {
          Console.WriteLine("Enter the Deposite Amount");
          int am=int.Parse(Console.ReadLine());
          acc._Bal= acc._Bal+am;
            Console.WriteLine("Deposit Added Successfully");
            Console.WriteLine("Your updated balace is:"+" "+acc._Bal);
    }
         
     }
    void Withdraw()
     {  
         Console.WriteLine("Enter the account number");
         int acno=int.Parse(Console.ReadLine());
        
         BankAt acc=null;
          foreach (var f in c)
        {
          if(f._AccNo==acno)
          {
         acc=f;
         break;
        }
        }
      if(acc!=null)
      {
          Console.WriteLine("Enter the Withdrawn Amount");
          int am=int.Parse(Console.ReadLine());
          acc._Bal= acc._Bal-am;
            Console.WriteLine("Amount withdrawn Successfully");
            Console.WriteLine("Your updated balace is:"+" "+acc._Bal);
    }
         
     }
     void BalanceCh()
     {   
         Console.WriteLine("Enter the account number");
         int acno=int.Parse(Console.ReadLine());
        
         BankAt acc=null;
          foreach (var f in c)
        {
          if(f._AccNo==acno)
          {
         acc=f;
         break;
        }
        }
        if(acc!=null)
        {
            Console.WriteLine("Your Account Balance is"+" "+acc._Bal);
            
        }
         
     }
     void AccountDet()
     {
         Console.WriteLine("Enter the account number");
         int acno=int.Parse(Console.ReadLine());
        
         BankAt acc=null;
          foreach (var f in c)
        {
          if(f._AccNo==acno)
          {
         acc=f;
         break;
        }
        }
        if(acc!=null)
        {   
            Console.WriteLine("Your Account Number is"+" "+acc._AccNo); 
            Console.WriteLine("Your Account Name is"+" "+acc._Name);
            Console.WriteLine("Your Account Balance is"+" "+acc._Bal);
            
        }
     }
         

}