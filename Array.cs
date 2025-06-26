
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Analytics;

public class Arraypractice: MonoBehaviour
{
void Start()
{
    int []Array1=new int[10];
    Array1[0]=5;
    Array1[2]=8;
    Array1[4]=11;
    Array1[9]=22;
    for(int i=0;i < Array1.Length;i++){
      //  Debug.Log(Array1[i]);
    }
  int[] Array2=new int[0];
  string []Array3=new string[4];
  string []Array4={"hello","How","Are","You"};
  string []Weekdays={"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};
  foreach(string day in Weekdays){
  //  Debug.Log(day);

    //reverse loop
    for(int j=Weekdays.Length-1;j>=0;j--)
    {
//Debug.Log(Weekdays[j]);
    }
//Array.Reverse(Weekdays);
Array.Sort(Weekdays);
foreach (string Revv in Weekdays){
  //  Debug.Log(Revv) ;
}
char []Alpha=new Char[26];
  /*  for(int k=0;k<26;k++)
    {
        Alpha[k]=(char)('A'+k);
      //  Debug.Log(Alpha[k]);
    }*/
    for (int l=0;l<26;l++)
    {
       Alpha[l]= (char)('Z'-l); 
       //Debug.Log(Alpha[l]);    
    }

  }
} 

void Update()
{
    if(Input.anyKeyDown)
    {
        string keyName=Input.inputString;
        Debug.Log(keyName);
    }

}









}