using System;

namespace COPYCODE
{
    //short an arryy  use b y logic 
    public class copycode34
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 8, 1, 3 };
            for(int i=0; i<arr.Length-1; i++)
            {
                for(int j=0; j<arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp=arr[j];
                        arr[j]=arr[j + 1];
                        arr[j+1]=temp;
                    }
                }
            }
          

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }


        }
    }
}