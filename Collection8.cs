using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class Collection8 : MonoBehaviour
{

    void Start()
    {
        Student n = new Student();
        n.All(1, "Raku", "ACTING", 45f);
        n.All(8, "Ronit", "Comics", 75f);
        n.All(4, "Kishor", "Rider", 55f);
        n.All(9, "Kishor", "Rider", 55f);
        n.All(3, "Kishor", "Rider", 55f);
        n.All(7, "Kishor", "Rider", 55f);
   

                foreach(Student a in n)
                 {
         Debug.Log(a.Rno+" "+a.Name+" "+a.Hobby+" "+a.Marks);
                 }
                 n.All(1, "Raku", "ACTING", 45f);

                  foreach(Student a in n)
                 {
         Debug.Log(a.Rno+" "+a.Name+" "+a.Hobby+" "+a.Marks);
                 }
        //           n.Remover(4);///on removal giving error that collection is modified 
        //           foreach(Student v in n)
        //          {
        //  Debug.Log(v.Rno+" "+v.Name+" "+v.Hobby+" "+v.Marks);
                 }
    //  Student b = n.Search(8);
    
        //Debug.Log(b.Rno + " " + b.Name + " " + b.Hobby + " " + b.Marks);
    }

    // Update is called once per frame
    

public class Student : IEnumerable,IComparable<Student>
{

    public int Rno { get; set; }
    public string Name { get; set; }

    public string Hobby { get; set; }

    public float Marks { get; set; }

    private List<Student> students = new List<Student>();

    public void All(int rno, string name, string hobby, float marks)
    {
        Student student = new Student { Rno = rno, Name = name, Hobby = hobby, Marks = marks };
        students.Add(student);
     
        students.Sort();
    }

    public IEnumerator GetEnumerator()
    {
        return students.GetEnumerator();
    }
    // public Student Search(int id)
    // {
    //     foreach (Student student in students)
    //     {
    //         if (student.Rno == id)
    //         {
    //             return student;
    //         }
    //     }
    //     return null;

    // }
public void Remover(int id)
    {
        foreach (Student student in students)
        {
            if (student.Rno == id)
            {
                
              students.Remove(student);  
            }
        }
    

    }
    public int CompareTo(Student other)
    {
        // if(this.Rno>other.Rno)
        // return 1;
        // else if(this.Rno<other.Rno)
        // return -1;
        // else
        // return 0;
        if(this.Marks>other.Marks)
        return 1;
        else if(this.Marks<other.Marks)
        return -1;
        else
        return 0;
    }
}
// public class StudentManager
// {
// private List<Student> students;

// public StudentManager()
// {
// students=new List<Student>();
// }
// public void AddStudent(int rno,string name,string hobby,float marks)
// {
//     Student student=new Student{Rno=rno,Name=name,Hobby=hobby,Marks=marks};
//     students.Add(student);   
// }



