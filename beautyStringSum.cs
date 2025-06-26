using System;
using System.Collections.Generic;



public class HelloWorld
{
    public static void Main(string[] args)
    {
        string a = "aabcbaa";
        BeautySubstrings(a);///Beauty of Substring this means anySubstring having Maxcount and MinCount
                //  then find difference and sum of it;Here aab=2-1,aabc=2-1,aabcb=2-1,aabcba=3-1,aabcbaa=4-1,...continue like that 
    }
    
    static void BeautySubstrings(string a)
    {
        int ans = 0;
        Dictionary<char, int> all = new Dictionary<char, int>();
        
        for (int l = 0; l < a.Length; l++)
        {
            all.Clear();
            for (int r = l; r < a.Length; r++)
            {
                // Update the frequency of the current character
                if (all.ContainsKey(a[r]))
                {
                    all[a[r]]++;
                }
                else
                {
                    all[a[r]] = 1;
                }

                // We are only interested in substrings with more than one distinct character
                if (all.Count >= 2)
                {
                    // Find max and min frequency in the current window
                    int max = all.Values.Max();
                    int min = all.Values.Min();
                    
                    // Add the beauty (max - min) for the current substring
                    ans += (max - min);
                }
            }
        }
        
        Console.WriteLine(ans);
    }
}
