using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class Properties : MonoBehaviour
{
   
   int _Custid;
    bool _Status;
    string _Cname;
    double _Balance;
    Cities _City ;//enum
    string _State;

   // string _Country;

       
public enum Cities
{
    Delhi,Mumbai,Chennai,Banglore
}
        public Properties(int Custid,bool Status,string Cname,double Balance,Cities City,string State,string Country)
    {
        _Custid=Custid;_Status=Status;_Cname=Cname;_Balance=Balance;
        _City=City;_State=State;  //_Country=Country;
        this.Country=Country;
    }
    public int Custid
    {
        get { return _Custid;}
            
        
       set { _Custid =value;}
   }
   public bool Status
   {
    get {return _Status;} 

    set {

_Status = value;}
   }
   public string Cname
   {
    get {   return _Cname;} 

    set { 
        if(_Status==true)
        _Cname = value;}
   }

public double Balance
{
    get { return _Balance;}
    
    set {
        if(_Status==true)
        {
            if(value>500)
            {

         _Balance = value;}}
        
        }

}
public Cities City
{
    get { return _City;}
    set {
        if(_Status==true)
        _City=value;}
}
// public string City
// {
//     get {return _City;}
//     set {
//         if(_Status==true)
//         {if(value=="Delhi"||value=="Mumbai"||value=="Chennai"||value=="Banglore")
        
//         _City=value;
//         }
//         }
// }

public string State 
{
    get{ return _State;}
   protected set{if(_Status==true)//we can set acess  each property that is using this  we can change only in child class 
        _State=value;}
}

public string Country                    //automated variable
 {   get;
   set;
}

}

    // Update is called once per frame
 

