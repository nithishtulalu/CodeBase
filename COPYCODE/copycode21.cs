using System;

namespace COPYCODE
{
    // find max word in a string
    public class copycode21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string:");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');

            int maxlen = 0;
            string maxword = " ";
            foreach (string word in words)
            {
                if (word.Length > maxlen)
                {
                    maxlen = word.Length;
                    maxword = word;
                }
            }
            Console.WriteLine(maxword);

        }
    }
}