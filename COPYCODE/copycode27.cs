using System;

namespace COPYCODE
{
    // find the  avg of   positive numbers
    public class copycode27
    {
        static void Main(string[] args)
        {
            int[] numbers = { -10, 25, -3, 0, 8, -7, 42, -1, 19 };
            int sum = 0;
            int count = 0;
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    sum += number;
                    count++;
                }
            }
            Console.WriteLine("Avg "+sum/count);


        }
    }
}
