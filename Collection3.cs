using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class Collection3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Collection3 obj=new Collection3();
       obj.dict();
    }

public void dict(){
     Dictionary<string,object> dt =new Dictionary<string,object>();
        
          dt.Add("Eid",101);
          dt.Add("Ename","Scott");
          dt.Add("Job","Manager");
          dt.Add("Salary",25000);
          dt.Add("Mgrid",1002);
          dt.Add("Phone","22255544467");
          dt.Add("Email","raku@gmail.com");
          dt.Add("Dname","Sales");
          dt.Add("Location","Mumbai");
          dt.Add("Did",30); 
          Debug.Log(dt["Email"]);
          Debug.Log("Hello".GetHashCode());

          foreach(string key in dt.Keys){
           Debug.Log(key+":"+dt[key]);

          }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
