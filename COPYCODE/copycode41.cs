using System;
using System.Collections.Generic;

namespace COPYCODE
{
    //Removing  Duplicates   from  a  given  string 
    public class copycode41
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string ::");
            string str = Console.ReadLine();
            HashSet<char> set = new HashSet<char>();
            string result = " ";
            foreach (char c in str)
            {
                if (set.Add(c))
                {
                    result = result + c;
                }
                
            }
            Console.WriteLine(result);

        }
    }
}
