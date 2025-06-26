using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Specialchar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         
    
    bool d=Check();
    if(d==false)
    {
   Debug.Log("Not Present Special Character");
    }
    else
    {
         Debug.Log(" Present Special Character"); 
    }
    }
    
    
   static bool Check()
    {
    string a="kjhdhjf*&#";
    string c="abcdefghijklmnopqrstucwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
   foreach(char ch in a)
   {
    if(!a.Contains(c))
        {
            Debug.Log(ch);
         return true;
        }
        
   }
   return false;
    }
    }
    // Update is called once per frame
 


 using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    string a="3hjdppp,l";
    bool d=false;
    foreach(var b in a)
    {
        int c=(int)b;
      if((c<'A' || c>'Z') && (c<'0' || c>'9') && (c<'a' || c>'z'))
      {
          d=true;
          break;
      }
    }
    if(d)
    {
        Console.WriteLine("it has special char");
    }
    else
    {
        Console.WriteLine("it does not have special char");
    }
    int f=58;
    char g=(char)f;  
    Console.WriteLine(g);

}}                                                                                  