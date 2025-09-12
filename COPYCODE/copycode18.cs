using System;

namespace COPYCODE
{
    // Reverse each word in a string
    public class copycode18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                Array.Reverse(chars);
                words[i]=new string(chars);

            }
            string result= string.Join(" ", words);
            Console.WriteLine(result);

        }
    }
}
