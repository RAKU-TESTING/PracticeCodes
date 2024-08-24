using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class Programs : MonoBehaviour,IComparable<Programs>,IEnumerable
{ 
    public int Rno { get; set; }
    public string Name { get; set; }

    public string Hobby { get; set; }

    public float Marks { get; set; }
    public Dictionary<int,Programs> dicto=new Dictionary<int, Programs>();
    public void All(int rno, string name, string hobby, float marks,int a)
    {
        Programs d = new Programs { Rno = rno, Name = name, Hobby = hobby, Marks = marks };
    dicto[a]=d;
    
     
        
    }
      public override string ToString()
    {
        return $"Rno: {Rno}, Name: {Name}, Hobby: {Hobby}, Marks: {Marks}";
    }
void Start()
    {
      Programs n=new Programs();
   //   n.Product(); 
     // n.Lowest(); 
    //  n.Sum();
    //n.Gap();
   // n.Duplicate();
  // n.Dicto();                                                       
   // n.Search(6);
   n.All(1, "Raku", "ACTING", 45f,1);
        n.All(2, "Ronit", "Comics", 75f,2);
        n.All(8, "Kishor", "Rider", 55f,6);
        n.All(9, "Kishor", "Rider", 55f,4);
        n.All(3, "Kishor", "Rider", 55f,5);
        n.All(7, "Kishor", "Rider", 55f,8);
  
   n.dicto.Remove(5);
    foreach(KeyValuePair<int,Programs> p in n.dicto)
   {
Debug.Log("Key:"+p.Key+" "+p.Value.ToString());
   }
   
     }
void Product()
{
int a=68;
int[] b={5,11,8,7,2,34,56};
for (int i=0; i < b.Length-1;i++)
{   
    for(int j=i+1; j < b.Length-1;j++)
{
    int c=b[i]*b[j];
    if(c==a)
    {
        Debug.Log(b[i]+" "+b[j]);
    }
}
}
}

void Lowest()
{
    int[] b={1,2,3,4,5,7,9};
    for(int i=0; i < b[b.Length-1];i++)
    {
    { if(b[i+1]==b[i]+1)
       {

       }    
       else
       {
        Debug.Log(b[i]+1);
       }
    }}
    }

void Sum()
{
    int []a={7,5,85,9,11,23,18};
    Array.Sort(a);
   
    int c=0;
    int b=0;
    
    for(int i=0;i<a.Length;i++)
    { 
        if(Check(a[i]))
    {
        c=c+a[i];
    }
    }
    Debug.Log(c);
    bool Check(int number)
    { b=0;// b is resetting every time
           for (int j = 2; j <= number; j++)
        {
            if (number % j == 0) 
            b++;
        }
        if(b==1)
        return true;
        else
        return false;
    }
   }
   void Gap()
   {
 int[] b={200, 300, 250, 151, 162 };
 //Array.Sort(b)
 int c;
 int d=int.MaxValue;
 
 {
    for(int i=0;i<b.Length;i++)
    {
        for(int j=0;j<b.Length;j++)
        {
             c=b[i]-b[j]; 
             if(c<=d && c>0)
             {
                d=c;
             }
        }
    }
    Debug.Log(d);
 }
}
void Duplicate()
{int c=0;
  int []a={7,5,85,5,9,11,23,11,18};
int []b=new int[a.Length-c];
for(int i=0;i<a.Length;i++)
{ bool duplicate=false;
    for(int j=i+1;j<a.Length;j++)
    {
        if(a[i]==a[j])
        {
            c++;
            duplicate=true;
        }
        
        
}
if(!duplicate)
{
Debug.Log(a[i]);
}
// Debug.Log(c);

}
}


// void Dicto()
// {
   
//     dicto.Add(1,62);
//     dicto.Add(2,48);
//      dicto.Add(3,62);
//     dicto.Add(4,58);
//      dicto.Add(5,72);
//     dicto.Add(6,76);
//      dicto.Add(7,62);
//     dicto.Add(8,80);

// foreach(KeyValuePair<int,int> d in dicto)
// {
//     Debug.Log("Key:"+" "+d.Key+" "+d.Value);
// }  
// }
// void Search(int e)
// {
//    Programs a=new Programs(); 
//     if(dicto.ContainsKey(e))
//     {
//       Debug.Log("Key"+" "+e+" "+dicto[e]);

//     }
// }
void Dicto()
{
    
}

    public int CompareTo(Programs other)
    {
        if(this.Marks>other.Marks)
          return 1;
          else if(this.Marks<other.Marks)
          return -1;
          else
          return 0;
    }

    public IEnumerator GetEnumerator()
    {
        return dicto.GetEnumerator();
    }
}




