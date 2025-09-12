using System;
using System.Collections.Generic;

namespace COPYCODE
{
    //Count character occurrence in a string
    public class copycode15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  a   string");
            string str = Console.ReadLine();
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic[c] = 1;
                }
            }

            foreach(var iteam in dic)
            {
                Console.WriteLine(iteam.Key +":"+iteam.Value);
            }

        }
    }
}