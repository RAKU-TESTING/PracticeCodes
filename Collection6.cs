using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // Practice();
      Students nO=new Students();
   nO.Result();
//    Students y= nO.BYId(4);
//    if(y!=null)
//    {
// Debug.Log($"{y.id} {y.Name} {y.Marks} {y.Surname} {y.Grade}");
//    }
//    else
//    {
//     Debug.Log("Number not found");
//    }
    }
    public void Practice()
{
 List<int> a=new List<int>();
 a.Add(10);
a.Add(5);a.Add(15);a.Add(16);

a.Insert(3,44);
a.Sort();
a.RemoveAt(1);
foreach (int i in a)
{
    Debug.Log(i);
}

}}
public class Students:IComparable<Students>
{ 
//      public static int CompareNames(Students S1,Students S2)

// {
//     return S1.Name.CompareTo(S2.Name);
// }    
    
    
    
     public List<Students> student;
    public int id{get;set;}
    public string Name {get;set;} 
    public int Marks{get;set;}
    public  string Surname{get;set;}
    char _Grade;
    public char Grade
    {
           get { return _Grade;}
   
            set{
                _Grade = value;
            }
    }  
    //  public int CompareTo(Students other)
    // {
    //  if(this.id>other.id)
    //  return 1;
    //  else if(this.id<other.id)
    //  return -1;
    //  else
    //  return 0;
    //   //  throw new NotImplementedException();
    // }     
     public int CompareTo(Students other)
    {return this.Surname.CompareTo(other.Surname);
     
      //  throw new NotImplementedException();
    }     
public void Result()
{
//List<Students> student= new List<Students>();

Students s1=new Students{id=51,Name="Harry",Surname="Potter",Marks=45,_Grade='C'};
Students s2=new Students{id=25,Name="Hermini",Surname="Mark",Marks=75,_Grade='B'};
Students s3=new Students{id=36,Name="Noddy",Surname="Desouza",Marks=60,_Grade='B'};
Students s4=new Students{id=48,Name="Ron",Surname="Decosta",Marks=44,_Grade='C'};
Students s5=new Students{id=59,Name="Mark",Surname="Henry",Marks=81,_Grade='A'};

student= new List<Students>{s1,s2,s3,s4,s5};
student.Sort();
//student.Reverse();
//CompareStudents obj =new CompareStudents();
//student.Sort(obj);
//Comparison<Students> obj=new Comparison<Students>(CompareNames);
//student.Sort(obj);
//student.Sort(CompareNames);
//student.Sort(delegate (Students s1, Students s2){return s1.Name.CompareTo(s2.Name);});

foreach (Students s in student)
{
Debug.Log(s.id+" "+s.Name+" "+s.Marks+" "+s.Surname+" "+s.Marks+" "+s._Grade);
// if(s.id==1)
// {
//     Debug.Log(s.id+" "+s.Name+" "+s.Marks+" "+s.Surname+" "+s.Marks+" "+s._Grade);
// } 
}

//Debug.Log(student[1]);

}
public Students BYId(int id)
{


    if (student == null)
        {
            Debug.Log("Student list is not initialized.");
            return null;
        }
    foreach (Students stud in student)
    {
        if(stud.id==id)
       { return stud;}
    }
    return null;
}
   
}
class CompareStudents : IComparer<Students>
{
    public int Compare(Students x, Students y)
    {
        if(x.Marks>y.Marks)
        return 1;
        else if(x.Marks<y.Marks)
        return -1;
        else
        return 0;
    }

   
}

