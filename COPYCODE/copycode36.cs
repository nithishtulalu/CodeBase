using System;
using System.Collections.Generic;

namespace COPYCODE
{
    //Given a list of strings, return only those 
    //strings that are palindromes (words that read the 
    //same forward and backward, like "madam" or "racecar").
    public class copycode36
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "madam", "hello", "racecar", "world", "level", "nithish" };

           for(int i = 0; i <= list.Count; i++)
            {
                string word=list[i];
                string rev = "";
                for(int j = word.Length - 1; j >= 0; j--)
                {
                    rev =rev+word[j];

                }
                if (word.ToLower() == rev.ToLower())
                {
                    Console.WriteLine(word);
                }
            }


        }
    }
}