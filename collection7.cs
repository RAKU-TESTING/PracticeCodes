using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collection7 : MonoBehaviour
{
   
    

   public int id{get; set;}

   public string name {get; set;}  

   public string job {get; set;}

   public double salary {get; set;}

   void Start()
    {
    Testemployee obj=new Testemployee();
        obj.Em();
      Organization o=new Organization();
      
    }

}
public class Organization:IEnumerable///to implement we want to show IEnumerator interface method GetEnumerator
{
List<collection7>Emps=new List<collection7>();//List of employ 
public void Add(collection7 emp)
{
Emps.Add(emp);


}

    public IEnumerator GetEnumerator()
    {
    return Emps.GetEnumerator();
       // throw new System.NotImplementedException();
    }
}
public  class Testemployee
{
  public void Em()
  {
   // List<collection7> employees = new List<collection7>();
      Organization employees=new Organization();
    employees.Add(new collection7{id=101,name="raku",job="manager",salary=25000.0});
    employees.Add(new collection7{id=105,name="ronit",job="TeamLeader",salary=40000.0});
    employees.Add(new collection7{id=108,name="vikram",job="Salesman",salary=20000.0});
    employees.Add(new collection7{id=106,name="kishor",job="Salesman",salary=20000.0});
    employees.Add(new collection7{id=104,name="raju",job="Salesman",salary=23000.0});
    employees.Add(new collection7{id=105,name="rahul",job="cleark",salary=18000.0});

    foreach (collection7 Emp in employees)
    {
        Debug.Log(Emp.id+" "+Emp.name+" "+Emp.job+" "+Emp.salary);
    }
  }






}