using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class Collection4 : MonoBehaviour
{
   public int Custid{get;set;}

public string Name{get;set;}

public string City{get;set;}

public double Balance{get;set;}

    void Start()
    {
        List <Collection4> Customers = new List<Collection4>();
  // Customers.Add(new Collection4{ Custid=101,Name="rakesh",City="Pune",Balance=25444.0});

        Collection4 C1 = new Collection4 { Custid = 101, Name = "rakesh", City = "Pune", Balance = 25360.0 };
        Collection4 C2 = new Collection4 { Custid = 102, Name = "Akshay", City = "Gondia", Balance = 300000.0 };
        Collection4 C3 = new Collection4 { Custid = 103, Name = "Rajesh", City = "Nashik", Balance = 8544.0 };
        Collection4 C4 = new Collection4 { Custid = 104, Name = "Sumit", City = "Igatpuri", Balance = 38000.0 };

        Customers.Add(C1);Customers.Add(C2);Customers.Add(C3);Customers.Add(C4);
        foreach(Collection4 all in Customers)
        {
        Debug.Log(all.Custid+" "+all.Name+" "+all.City+" "+all.Balance) ;   
        }                  
    }
    }


// public class TestCustomer
// {
  

// //    List <Collection4> Customers = new List<Collection4>();
//    public TestCustomer()
//    {
//      List <Collection4> Customers = new List<Collection4>();
//    Customers C1=new Customers(Custid=101,Name="rakesh");
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   













