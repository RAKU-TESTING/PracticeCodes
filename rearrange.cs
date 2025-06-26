// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={1,2,-3,-1,-2,-3};
        List<int>pos=new List<int>();
        List<int>neg=new List<int>();
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]>0)
            {
                pos.Add(a[i]);
            }
            else
            {
                neg.Add(a[i]);
            }
        }
        // Console.WriteLine(pos.Count);
        //  Console.WriteLine(neg.Count);
        int posindex=0;
        int negindex=0;
        for(int i=0;i<a.Length;i++)
        {
            if(i%2==0)
            {
                if(pos.Count>0)
                {
                a[i]=pos[posindex];
               pos.RemoveAt(posindex);
                }
                else
                {
                a[i]=neg[negindex];
                neg.RemoveAt(negindex);
                }
            }
            else
            {   
                if(neg.Count>0)
                {
                    a[i]=neg[negindex];
                
                neg.RemoveAt(negindex);
                
                }
                else
                {
                a[i]=pos[posindex];
                pos.RemoveAt(posindex);
                }
                
            }}
        foreach(var c in a)
        {
            Console.WriteLine(c);
        }
        
    }
}






using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = { 1, 2, -3, -1, -2, -3 };
        List<int> pos = new List<int>();
        List<int> neg = new List<int>();

        // Step 1: Segregate the array into positive and negative lists
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > 0)
                pos.Add(a[i]);
            else
                neg.Add(a[i]);
        }

        // Step 2: Rearrange the array using indices
        int posIndex = 0, negIndex = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (i % 2 == 0)  // Even index: add positive if available
            {
                if (posIndex < pos.Count)
                    a[i] = pos[posIndex++];
                else
                    a[i] = neg[negIndex++];
            }
            else  // Odd index: add negative if available
            {
                if (negIndex < neg.Count)
                    a[i] = neg[negIndex++];
                else
                    a[i] = pos[posIndex++];
            }
        }

        // Step 3: Print the rearranged array
        foreach (var c in a)
        {
            Console.WriteLine(c);
        }
    }
}
