using System;

namespace COPYCODE
{
    //Check if array contains a specific value
    public class copycode26
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine("Enter  key");
            int key = int.Parse(Console.ReadLine());
            bool check = false;
            foreach (int i in num)
            {
                if (i == key)
                {
                    check = true;
                    break;
                }

            }
            if (check)
            {
                Console.WriteLine("yes    we find key");
            }
            else
            {
                Console.WriteLine("no key found");
            }


        }
    }
}