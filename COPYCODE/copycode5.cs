using System;

namespace COPYCODE
{
    //Factorial of a given number
    public class copycode5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number ");

            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"factorila of :{num} is {fact}");


        }
    }
}