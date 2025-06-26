using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using static Collection5;

public class Collection5 : MonoBehaviour,IComparable<Collection5>
{     
    public int Sid{get;set;}

public string Name{get;set;}

public int Class{get;set;}

public float Marks{get;set;}

    // public int CompareTo(Collection5 other)
    // {
    //     if(this.Sid>other.Sid)
    //     return 1;
    //     else if(this.Sid<other.Sid)
    //     return -1;
    //     else 
    //     return 0;
    // }
    public int CompareTo(Collection5 other)
    {
        if(this.Marks>other.Marks)
        return 1;
        else if(this.Marks<other.Marks)
        return -1;
        else 
        return 0;
    }
  public   class CompareStudents : IComparer<Collection5>
    {
        public int Compare(Collection5 x, Collection5 y)
        {
           if(x.Marks>y.Marks)
           return 1;
           else if(x.Marks<y.Marks)
           return -1;
           else return 0;
        }
    }

    void Start()
{
 //TestStudent n=new TestStudent();
// n.NOpe();  
 // CompareStudents stu=new CompareStudents();

}

}

public class TestStudent
{
public void NOpe()
    {

        Collection5 s1=new Collection5{Sid=103,Name="Ajay",Class=10,Marks=575.0f};
         Collection5 s2=new Collection5{Sid=105,Name="Sumit",Class=10,Marks=680.0f};
          Collection5 s3=new Collection5{Sid=101,Name="Akshay",Class=10,Marks=595.0f};
           Collection5 s4=new Collection5{Sid=109,Name="Kishor",Class=10,Marks=510.0f};
            Collection5 s5=new Collection5{Sid=119,Name="Rutvik",Class=10,Marks=480.0f};
            
            List <Collection5>students=new List<Collection5>{s1,s2,s3,s4,s5};
           
            CompareStudents stu=new CompareStudents(); 
             //students.Sort(stu);



             
             //  students.Sort(0,5,stu);

           

            foreach (Collection5 s in students)  
            {
                Debug.Log(s.Sid+" "+s.Name+" "+s.Class+" "+s.Marks);
            }  
    }

}
