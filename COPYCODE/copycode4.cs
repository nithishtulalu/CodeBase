using System;

namespace COPYCODE
{
    //Check if given number is prime or not
    public class copycode4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }

            }
            if (count == 2)
                Console.WriteLine("Given num is  prime");
            else
                Console.WriteLine("not primer");

        }
    }
}