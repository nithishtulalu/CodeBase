using System;

namespace COPYCODE
{
    //Reverse a string
    public class copycode19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string rev = " ";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine(rev);

        }
    }
}