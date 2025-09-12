using System;

namespace COPYCODE
{
    // find min word  in string
    public class copycode22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            int minlen = int.MaxValue;
            string minword = " ";
            foreach (string word in words)
            {
                if (word.Length < minlen)
                {
                    minlen = word.Length;
                    minword = word;
                }
            }
            Console.WriteLine(minword);

        }
    }
}