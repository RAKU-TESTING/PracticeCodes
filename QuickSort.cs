using System;

class QuickSortExample
{
   static void Main(string []args)
   {
       int []arr={7,6,10,5,9,2,1,15,7};//  Array for Sorting
       int lb=0;int ub=arr.Length-1;  //make variable lower bound And Upper Bound
       QuickSort(arr,lb,ub);    /// QuickSort MEthod Called
       foreach(int a in arr)
       {
       Console.Write(a+" ");
       }
      
   }
   static void QuickSort(int[] arr,int lb,int ub)
   { 
       int log=0;///make variable log to get Variable from Partion Method
       if (lb<ub) //Add condition to it lb should be smaller
       {
           log=Partition(arr,lb,ub);  //Called Partition Mehod with int return type
           QuickSort(arr,lb,log-1);
            QuickSort(arr,log+1,ub);
       
       }
    }
    static int Partition(int []arr,int lb,int ub)
    {
        int pivot=arr[lb];//make One Pivot 
        int start=lb;//make one start point for iteration
        int end=ub;//make another end point for iteration to start from End
        while(start<end)
        {
        while(arr[start]<=pivot)//first we iterate from start with condition
        {
            start++;
        }
        while(arr[end]>pivot)//We iterate From end to start with Condition
        {
            end--;
        }
        if(start<end)
        {
            Swap(arr,arr[start],arr[end]);
        }
        }
        Swap(arr,lb,end);
        return end;
    }
    static void Swap(int []arr,int lb,int ub)
    {
        int temp=arr[lb];
        arr[lb]=arr[ub];
        arr[ub]=temp;
    }
    
}