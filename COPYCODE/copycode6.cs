using System;

namespace COPYCODE
{
    //Sum of elements in an array
    public class copycode6
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int sum = 0;
            foreach (int i in arr)
            {
                sum = sum + i;

            }
            Console.WriteLine(sum);
        }
    }
}