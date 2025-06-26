// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       
     int[] a={5,6,9,7,4,5};
     int[] b={7,5,9,4};
     Check(a,b);
     
    } 
     static void Check(int[] arr, int[] arr2)
    {
        bool k = true;
        for (int i = 0; i < arr2.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr2[i] == arr[j])
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                k = false;
                break;
            }
        }
            if(!k)
            {
        }
        if(k)
        {
            Console.WriteLine("Subaarray is Equal");
        }
        else
        {
              Console.WriteLine("Subaarray is not Equal");
        }
    }
}
// using System;
also used this Program;
// public class HelloWorld
// {
//     public static void Main(string[] args)
//     {
       
//      int[] a={5,6,9,7,4,5};
//      int[] b={7,9,6};
//      Check(a,b);
     
//     } 
//     static void  Check(int[] arr,int[] arr2)
//     {   bool k=false;
//         for(int i=0;i<arr2.Length;i++)
//         {
//             for(int j=0;j<arr.Length;j++)
//             {
//                 if(arr2[i]==arr[j])
//                 { 
//                     k=true;
//                  break;
//                 }
//                  else
//                  {
//                      k=false;
//                     // break;
//                  }
//             }
           
//         }
//         if(k)
//         {
//             Console.WriteLine("arr2 is subset of arr");
//         }
//         else
//         {
//               Console.WriteLine("arr2 is not subset of arr");
//         }
//     }
// }