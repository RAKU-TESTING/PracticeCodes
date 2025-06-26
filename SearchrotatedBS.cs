using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[]a={1,2,3,4,5,6,0};
        int target=5;
        Console.WriteLine(SearchElement(a,target));//here there is rotated array first identify which part 
                                                  // is sorted then Decide target is Present Or not Then applys Binary search
        
    }
    static int SearchElement(int []a,int target)
    {
        int l=0;int h=a.Length-1;int ans=-1;int mid=-1;
          while(l<=h)
        {
           mid=(l+h)/2;
           if(a[mid]==target)
           {
           
           ans=mid;
           return ans;
          }
          if(a[l]<=a[mid])
            {
          if(target<a[mid]  && a[l]<=target)
          {
             h=mid-1;
          }
          else
          {
              l=mid+1;
          }
            }
          else
            {
              if(target>a[mid] && target<=a[h])
              {
                  l=mid+1;
              }
              else
              {
                  h=mid-1;
              }
                
            }
        }
              return ans;
           }
        }