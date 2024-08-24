using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using System.Linq;  
public class DictionTask : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    // string input="Hello,hello World,this id hello world Example";    
    // string []input2=input.Split(',',' ');
    // int k=0;
    // for(int i=0;i<input2.Length;i++)
    // {for(int j=i+1;j<input2.Length;j++)
        
    //       if   (input2[i].Equals(input2[j]),StringComparison.OrdinalIgnoreCase)    
    //     {
    //                k++;
       
    //     }
    //      Console.WriteLine(input2[i] + ": " + (k + 1));
    // }
//       int count =0;
//       for(int i=2;i<=5000;i++)
//       {
//     if   (i%2==0)
//     {   count++;
//         if(count <=500){
            
//             Debug.Log(i);
//         }
//     }
// }Debug.Log(count);
        
// //     }
// int b=prime();
// if(b==1){Debug.Log(b);}
// int i=12;
//       string j=i.ToString();
//       Debug.Log(j);
//       int k=Convert.ToInt32(j[0].ToString());
//       Debug.Log(j[0]);
//       Debug.Log(k);
//       int l=Convert.ToInt32(j[1].ToString());
//       Debug.Log(l);
//       int m=k+l;
//       Debug.Log(m);
// string o= "ONce Upon a time";
// string []p=o.Split(" ");
// string reversedstring="";
// for(int i=p.Length-1;i>=0;i--)
// {
// reversedstring +=p[i];

// }
// Debug.Log (reversedstring);
// int num=0;int sum=0;
// for (int i = 1; i <=5000; i++)
// {int count =0;
//   for(int j=1; j <= i; j++)
//   {
//     if (i%j==0)
//     {
//       count++;
      
     
//     }

//   }
//    if(count==2)
//       {num++;
//       if(num<=500)
//         {sum =sum+i;}
//       }
// }
// Debug.Log (sum);
// int[] ar1={1,3,-5,4};
// int[] ar2={1,4,-5,-2};
// int[] ar3=new int[ar1.Length];
// ar3[0]=ar1[0]*ar2[0];
// ar3[1]=ar1[1]*ar2[1];
// ar3[2]=ar1[2]*ar2[2];
// ar3[3]=ar1[3]*ar2[3];
// foreach(int ar4 in ar3)
// {
//   Debug.Log(ar4);
// } 
// string s="The quick brown fox jumps over the lazy dog.";
// string b="";
// for(int i=s.Length-4;i<s.Length;i++)
// {b=b+s[i];
// // }Debug.Log(b+b+b+b);
// Debug.Log(First(15,-8));
// }
//  public static int First(int a,int b)
//     {int temp=0;int temp1=0;
      
//       if(a<0||b<0)
//     { a=Math.Abs(a); b=Math.Abs(b);}
//    }
//       else
//       { temp=Math.Abs(a-20);}
//  if(b<20)
//       { temp1=Math.Abs(20-b);
//        Debug.Log(temp);}
//       else
//       { temp1=Math.Abs(b-20);}
//        if(temp<temp1)
//        {return a;}
//       else
//      { return b;}



  
        //string input=Console.ReadLine();
//         int[] a={1,4,6,9,15};
        
//         // for (int i=min;i<=max;i++)
//         // { b[index]=i;
//         // index++;}
// // Array.Sort(a);
// // int count =0;

// // for(int j=0;j<a.Length-1;j++)
// // {int b=0;
// //     count+=a[j+1]-a[j]-1;
// //     b= a[j]+1;
// //     for(int i=b;i<a[j+1];i++)
// //     {
// //         Debug.Log(i);
// // }
// //         Debug.Log(count);
// //     }
//      int[] a={1,5,7,8,9};
//        int[] b={2,6,7,5,5};
//     int[] c=   a.Concat(b).ToArray();
//        foreach(int d in c)
//        {
// Debug.Log(d+" ");
//        }
    //  int []a={10,18,39,75,100}; 
    //     int n=1000;
    
   
    //     for(int i=0;i<a.Length;i++)
    //  { 
        
    //      for(int j=i+1;j<a.Length;j++)
    //      {
    //      if(a[i]*a[j]==n)
    //     { Debug.Log(a[i]+" "+a[j]);
    //      break;}
    //      }
    
    // }
     Properties obj= new Properties(101,false,"anish",5220.0,Properties.Cities.Banglore,"Karnataka","India");
 Debug.Log(obj.Custid);
 if(obj.Status==true)
 {
Debug.Log("Current Customer Staus is :Active"); 
 }
 else
 {
Debug.Log("Current Customer Staus is :InActive"); 
 }
Debug.Log("Current Customer Name :"+ obj.Cname);    
 obj.Cname +="Smith";//Assignment fail so below statement print old name only
Debug.Log("Modified Customer Name :"+ obj.Cname); 

obj.Status=true;
Debug.Log("Current Customer Name :"+ obj.Cname);    
 obj.Cname +="Smith";//Assignment pass name gets changed 
Debug.Log("Modified Customer Name :"+ obj.Cname); 

Debug.Log("Account Balance is "+ obj.Balance);
obj.Balance-=500;
Debug.Log("Account Balance is "+ obj.Balance);

obj.Status=false;
Debug.Log("Account Balance is "+ obj.Balance);
obj.Balance-=500;
Debug.Log("Account Balance is "+ obj.Balance);

obj.Status=true;
Debug.Log("Account Balance is "+ obj.Balance);
obj.Balance-=4500;//Applied min 500 bal requirement conditions
Debug.Log("Account Balance is "+ obj.Balance);

Debug.Log("Current City:"+obj.City);
// obj.City="Delhi";
obj.City=Properties.Cities.Banglore;
Debug.Log("Modified City:"+obj.City);

Debug.Log("Current State:"+obj.State);
Debug.Log("Country"+obj.Country);

      }}
    

    
    
    
    


    
    

