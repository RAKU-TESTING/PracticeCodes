// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a={4,5,9,6,7,8};
        int k=2;
        int[] rightrotated=RightRotate(a,k);
        
        foreach(var d in rightrotated)
        {
            Console.WriteLine(d);
        }
     //  int[] leftrotated=LeftRotate(a,k);
    } 
    static int[] RightRotate(int [] arr,int k)
        {  
            int n=arr.Length;
            k=k%n;
            int[] rotate=new int[n];
            for(int i=0;i<arr.Length;i++)
            {
                rotate [(i+k)%n]=arr[i];
            }
            return rotate;
        }
    }
