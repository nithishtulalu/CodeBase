using System;

namespace COPYCODE
{
    //Print odd and even elements in an array
    public class copycode7
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            Console.WriteLine("Printing odd");
            foreach (int i in arr)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }

            Console.WriteLine("Printing even");
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
 }
