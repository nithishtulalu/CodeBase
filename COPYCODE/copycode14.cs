using System;

namespace COPYCODE
{
    public class copycode14
    {
        //Find first and second largest element
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            int firstmax = 0;
            int secondmax = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > firstmax)
                {
                    secondmax=firstmax;
                    firstmax=arr[i];
                }
                else if(arr[i] > secondmax  && firstmax != secondmax)
                {
                    secondmax = arr[i];
                }
            }
            Console.WriteLine(firstmax+", "+secondmax);


        }
    }
}
