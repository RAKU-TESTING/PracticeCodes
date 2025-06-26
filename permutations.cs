using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = { 1, 1,1 };
        
        foreach (var final in Recursive(a))
        {
            Console.WriteLine(string.Join(", ", final));
        }
    }
    
    public static List<List<int>> Recursive(int[] a)
    {
        List<List<int>> ans = new List<List<int>>();
        HashSet<string> seen = new HashSet<string>(); // To store string representations of permutations
        Permute(0, a, ans, seen);
        return ans;
    }
    
    public static void Permute(int index, int[] a, List<List<int>> ans, HashSet<string> seen)
    {
        // Base case: if index reaches the end of the array, add permutation to the result list
        if (index == a.Length)
        {
            // Convert the array to a string for easy comparison (e.g., "1,1,2")
            string currentPermutation = string.Join(",", a);
            
            // Only add the permutation if it hasn't been seen before
            if (!seen.Contains(currentPermutation))
            {
                ans.Add(new List<int>(a));  // Add a new list to the result
                seen.Add(currentPermutation);  // Mark this permutation as seen
            }
            return;
        }

        // Iterate through the array from the current index to the end
        for (int i = index; i < a.Length; i++)
        {
            Swap(a, index, i);  // Swap elements at index and i
            Permute(index + 1, a, ans, seen);  // Recursively permute the rest of the array
            Swap(a, index, i);  // Backtrack: swap back to restore the original array state
        }
    }
    
    public static void Swap(int[] a, int c, int d)
    {
        int temp = a[c];
        a[c] = a[d];
        a[d] = temp;
    }
}











// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={1,2,3};
        int []b={2,1,3};
        List<int> d=new List<int>(b);
    List<List<int>> c =Permute(a);
        for(int i=0;i<c.Count;i++)
        { 
            var innerList= c[i];
            for(int j=0;i<innerList.Count;j++)
            {
            if(c.Contains(d))
            {
                Console.Write(innerList[j]);
            }
            }
        
    }}
    public static List<List<int>> Permute(int[] a)
    {
        List<List<int>> ans=new List<List<int>>();
        RecurPermit(0,a,ans);
        return ans;
    }
    public static void RecurPermit(int index,int[] a,List<List<int>> ans)
    {
        if(index==a.Length)
        {
            ans.Add(new List<int>(a));
            return ;
        }
        for(int i=index;i<a.Length;i++)
        {
           
            Swap(ref a[index],ref a[i]);
            RecurPermit(index+1,a,ans);
            Swap(ref a[index],ref a[i]);
        }
        
    }
    public static void Swap(ref int a,ref int b)
    {
        int temp=a;
        a=b;
        b=temp;
    }
}