    using System;

    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            int []a={1,2,3,4,5,6,7};
            int k=1;
            Leftadd(a,k);
            foreach(var b in a)
            {
            Console.WriteLine(b);    
            }
        }
        public static void Leftadd(int []a,int k)
        {
        int [] temp=new int[k];
        for(int i=0;i<k;i++)
        {
            temp[i]=a[i];
        }
        int index=0;
        for(int j=k;j<a.Length;j++)
        {
            a[index]=a[j];
            index++;
        }
        int s=0;
        for (int l=a.Length-k;l<a.Length;l++)
        {
            a[l]=temp[s];
            s++;
        }
        }