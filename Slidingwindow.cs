// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
         int []arr={2,5,1,7,10,11};
         int k=14;
         
         int l=0;int r=0;
         int sum=0;int maxlen=0;int maxsum=0;
         int maxl=0;int maxr=0;
         while(r<arr.Length)
         {
             sum=sum+arr[r];
             
             while(sum>k)
             {
                 sum=sum-arr[l];
                 l=l+1;
             }
             if(sum<=k )
              {   
                 if(sum>maxsum||maxlen<r-l+1 )
                 {   maxsum=sum;
                     maxlen=r-l+1;
                     maxl=l;
                     maxr=r;
                     
                     
                 }
                 
             }
             r++;
         }
         Console.WriteLine(maxlen);
        //  Console.WriteLine(maxl);
        //   Console.WriteLine(maxr);
         for(int i=maxl;i<=maxr;i++)
         {
             Console.WriteLine(arr[i]);
         }
              
            
         
             
             
    }
}





// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        int []arr={3,3,3,1,2,1,1,2,3,3,4,3,3,4};
        int maxtype=2;
        int maxlength=0;
        int l=0;
        List<int> n=new List<int>();
        HashSet<int> t=new HashSet<int>();
        for(int i=0;i<arr.Length;i++)
        {
            if(!n.Contains(arr[i]))
            {
                
               t.Add(arr[i]);
            }
            if(t.Count<=maxtype)
            {
                n.Add(arr[i]);
              
                if(i-l+1>maxlength)
                {
                    maxlength=i-l+1;
                    
                }
            }
           while(t.Count>maxtype)
             { 
                 if(n.Contains(arr[l]))
             {
                 n.RemoveAt(0);
             }
             if(!n.Contains(arr[l]))
             {
                 t.Remove(arr[l]);
             }
             l++;
                //  n.Add(arr[i]);
            //     t.Remove(arr[l]);
            //     while(n.Contains(arr[l]))
            //     { if(!t.Contains(arr[l]))
            //         {
            //         n.Remove(arr[l]);
            //          l++;
            //         }

                    
                }
               
            }
            Console.WriteLine(maxlength);
            
        
        }
        
    }




using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {    
         string a="aaabbccd";int r=0;int k=2;int l=0;int maxlength=0;
        Dictionary<char,int> n=new Dictionary<char,int>();
       while(r<a.Length)
        { 
           
           if(n.ContainsKey(a[r]))
            {    
               n[a[r]]++;
            }
            else
            {
                n[a[r]]=1;
            }
            if(n.Count<=k)
           {
            if(r-l+1>maxlength)
            {
                maxlength=r-l+1;
            }
            }
            else
            {
                while(n.Count>k)
                {
                    n[a[l]]--;
                    if(n[a[l]]==0)
                    {
                        n.Remove(a[l]);
                    }
                    l++;
                }
            }
            r++;
        }
        Console.WriteLine(maxlength);
    }





    // Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string a = "AABABBAAAA"; // Input string
        int k = 2; // Number of allowed replacements
        if (string.IsNullOrEmpty(a))
        {
            Console.WriteLine(0);
            return;
        }

        Dictionary<char, int> charCounts = new Dictionary<char, int>();
        int left = 0, right = 0, maxLength = 0;

        while (right < a.Length)
        {
            // Add current character to the dictionary
            if (charCounts.ContainsKey(a[right]))
            {
                charCounts[a[right]]++;
            }
            else
            {
                charCounts[a[right]] = 1;
            }

            // Find the count of the most frequent character in the current window
            int maxCount = 0;
            foreach (var count in charCounts.Values)
            {
                maxCount = Math.Max(maxCount, count);
            }

            // Check if we need to shrink the window
            while ((right - left + 1) - maxCount > k)
            {
                charCounts[a[left]]--;
                if (charCounts[a[left]] == 0)
                {
                    charCounts.Remove(a[left]);
                }
                left++;
            }

            // Update maximum length found
            maxLength = Math.Max(maxLength, right - left + 1);
            right++;
        }

        Console.WriteLine(maxLength);
    }
}



// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;