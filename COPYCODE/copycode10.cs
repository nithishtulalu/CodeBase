using System;

namespace COPYCODE
{
    //Find minimum and maximum number in array
    public class copycode10
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int max = arr[0];
            int min = arr[0];

            foreach (int i in arr)
            {
                if (i > max)
                    max = i;
                else if (i < min)
                    min = i;
            }
            Console.WriteLine($"max {max} and min{min}");

        }
    }
}
