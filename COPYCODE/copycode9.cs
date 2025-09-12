using System;

namespace COPYCODE
{
    //Missing number in an array
    public class copycode9
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 7, 8 };
            int sum1 = 0;
            int sum2 = 0;
            foreach (int i in arr)
            {
                sum1 = sum1 + i;
            }
            for (int i = 0; i <= 8; i++)
            {
                sum2 = sum2 + i;
            }

            Console.WriteLine("Missing number is  " + (sum2 - sum1));
        }

        }
    }
