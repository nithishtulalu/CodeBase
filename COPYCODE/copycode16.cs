using System;

namespace COPYCODE
{
    //Find first and second smallest element
    public class copycode16
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            int firstmin=int.MaxValue;
            int secondmin=int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < firstmin)
                {
                    secondmin =firstmin;
                    firstmin = arr[i];
                }
                else if (arr[i]<secondmin && firstmin != secondmin)
                {
                    secondmin = arr[i];
                }

            }
            Console.WriteLine($"firstmin{firstmin} , SecondMin{secondmin}");



        }

    }
}
