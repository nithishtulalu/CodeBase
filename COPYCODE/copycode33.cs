 using System;
using System.Linq;

namespace COPYCODE
{
    //Count  Vowels in  a string ==AEIOU
    public class copycode33
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str=Console.ReadLine().ToUpper();
            char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

            int count = 0;

            foreach (char ch in str)
            {
                if (vowels.Contains(ch))
                {
                    count++;
                }
            }


            Console.WriteLine(count);
        }
    }
}
