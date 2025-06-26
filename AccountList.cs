
using System;
using System.Collections.Generic;


public class BankAt
{  
    private static int accnos=1000;//in This we Learn How to create on class with parameters we require 
                            //Here we make that account number properties static && in Constructor we Make
                            //accountNos as ++; 
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
     public List<BankAt> c=new List<BankAt>();//Created List of that of datatype;
    public static void Main(string[] args)
    {  
        BankDetails b = new BankDetails();//Created object of datatype
     
       while (true)//this is important to relaunch the Menu options
       {
           Console.WriteLine("\nSelect your Choice");
           Console.WriteLine("1.Create Account");
           Console.WriteLine("2.Deposite");
           Console.WriteLine("3.Withdraw");
           Console.WriteLine("4.Balance Check");
           Console.WriteLine("5.Account Details");
           int n;
           Console.WriteLine("\nEnter your Choice");
           if(int.TryParse(Console.ReadLine(),out n))//this function return bool to Check why enter element is of int datatype;
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
        BankAt newacc=new BankAt(name,d);//Here we create New bank account of That datatype So we can add in list this please keep in mind;
        c.Add(newacc);//add the newaccount;
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
        
         BankAt acc=null;//here the create the null object and Search the account number in list and assign that account
                        //   wiil assign to it;
          foreach (var f in c)
        {
          if(f._AccNo==acno)
          {
         acc=f;//this is very important;
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