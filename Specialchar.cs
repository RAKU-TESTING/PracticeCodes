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
 