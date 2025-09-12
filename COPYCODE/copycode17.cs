using System;

namespace COPYCODE
{
    //Count number of words in a string
    public class copycode17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entera a string");
            string str = Console.ReadLine();

            string[] word = str.Split(' ');
            int len=word.Length;
            Console.WriteLine(len);
        }
    }
}
