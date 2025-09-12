using System;
using System.Collections.Generic;

namespace COPYCODE
{
    public class copycode37
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  a  String :");
            string str=Console.ReadLine();
            Dictionary<char,int> freq = new Dictionary<char,int>();
            foreach(char c in str)
            {
                if (freq.ContainsKey(c))
                {
                    freq[c]++;
                }
                else
                {
                    freq[c] = 1;
                }
            }
            char result = ' ';
            foreach(char c in str)
            {
                if (freq[c] == 1)
                {
                    result = c;
                    break;
                }
            }

            Console.WriteLine(result);


        }
    }
}
