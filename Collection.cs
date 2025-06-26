using System.Collections;
using System.Collections.Generic;
using System.Net.Cache;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Alist();
        NewBehaviourScript n=new NewBehaviourScript();
        bool result =n.Compare<int>(10,10);
        Debug.Log(result);
            bool result2 =n.Compare<float>(10.0f,10.1f);
        Debug.Log(result2);
       
    }
    public void Alist()
    {
         ArrayList al= new ArrayList();
         //Debug.Log(al.Capacity);
         al.Add(5);
          //Debug.Log(al.Capacity);
          al.Add(100);al.Add(300);  al.Add(500);al.Add(1);  
        //  Debug.Log(al.Capacity);
          Hashtable ht=new Hashtable();
          ht.Add("Eid",101);
          ht.Add("Ename","Scott");
          ht.Add("Job","Manager");
          ht.Add("Salary",25000);
          ht.Add("Mgrid",1002);
          ht.Add("Phone","22255544467");
          ht.Add("Email","raku@gmail.com");
          ht.Add("Dname","Sales");
          ht.Add("Location","Mumbai");
          ht.Add("Did",30); 
          Debug.Log(ht["Email"]);
          Debug.Log("Hello".GetHashCode());

          foreach(object key in ht.Keys )
          {
            Debug.Log(key);
          }
      //GENERIC COLLECTION\\
      List<int>li=new List<int>();
      li.Add(10);li.Add(140);li.Add(30);li.Add(20);

// for(int i=0;i<li.Count;i++)
// {
// Debug.Log(li[i]+" ");
// }
li.Insert(2,40);
li.RemoveAt(3);
for(int i=0;i<li.Count;i++)
{
Debug.Log(li[i]+" ");
}
    }
public bool Compare<T>(T a,T b)
{
    if(a.Equals(b))
{
return true;
}
return false;
}





    

    
}
