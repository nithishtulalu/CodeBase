using System;

namespace COPYCODE
{
    //    Togale case
    //Lowercase → Uppercase

    //Uppercase → Lowercase

    //Numbers & special characters remain the same
    public class copycode42
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enater a string ::");
            string str = Console.ReadLine();
            string output = " ";
            foreach (char c in str)
            {
                if (char.IsLower(c))
                {
                    output = output + char.ToUpper(c);
                }
                else if (char.IsUpper(c))
                {
                    output = output + char.ToLower(c);
                }
                else
                {
                    output = output + c;
                }

            }
            Console.WriteLine(str);
            Console.WriteLine(output);
        }
    }
}