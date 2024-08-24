// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

class QuickSortExample
   {
   static void Main(string []args)
   {
       int []arr={7,6,10,5,9,2,1,15,7};
       
       InsertionSort(arr);
        foreach (var c in arr)
       {
           Console.Write(c+" ");
       }
   }
   
   static void InsertionSort(int [] arr)
   {
       for(int i=0;i<arr.Length-1;i++)
       { 
           int min=i;
           for( int j=i+1;j<arr.Length;j++)
           {
             if(arr[j]<arr [min])
             {
                 min=j;
             }
           }
           if(min!=i)
           {
               Swap(arr,i,min);
           }
           
       }
      
   }
   static void Swap(int [] arr,int a,int b)
   {
       int temp=arr[a];
       arr[a]=arr[b];
       arr[b]=temp;
       
   }
  }