using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class DictionaryExpress : MonoBehaviour
{
   
   

    // Start is called before the first frame update
    void Start()
    {
//     string input="The quick brown fox jumps over the dog";
//     string[] words=input.Split(' ');
//        Dictionary<string,int> frequency=new Dictionary<string, int>();
// foreach(string c in words)
// {
//   if(frequency.ContainsKey(c))
//   {
//     frequency[c]++;
//   }
//   else
//   {
//     frequency[c]=1;
//   }
//   }
//   Console.WriteLine("Character frequency ");
//   foreach(var pair in frequency)
//   {
// Console.WriteLine($"{pair.Key}:{pair.Value}");
//   } 
   
   
}}




using System;
using System.Collections;
using System.Collections.Generic;
// using JetBrains.Annotations;
// using UnityEngine;

public class DictionaryExpress 
{
    
    public static void Main(string[] args)
    {
        string input="The quick brown fox jumps over the dog";
       Check(input);
    }
    static void Check(string input)
    {
    string[] words=input.Split(' ');//Here we Split the array string by space
        Dictionary<string,int> frequency=new Dictionary<string, int>();
foreach(string c in words)
{
  if(frequency.ContainsKey(c))
  {
    frequency[c]++;
  }
  else
  {
    frequency[c]=1;
  }
  }
//   Console.WriteLine("Character frequency ");
Array.Reverse(words);
string e="";
  foreach(var pair in words)
  {
   e+=pair+" ";
// Console.WriteLine($"{pair.Key}:{pair.Value}");
  } 
   Console.WriteLine(e);
   
}}
