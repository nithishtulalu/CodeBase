using System;

namespace COPYCODE
{
    //Find duplicates in an array
    public class copycode31
    {
        static void Main(string[] args)
        {
            string[] str1 = { "C#", "java", "sql" };
            string[] str2 = { "C#", "java", "sql", "mongoDb" };
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        Console.WriteLine(str2[i]);
                    }
                }

            }
            //Count characters in a string
            Console.WriteLine("eneter a a   strning");
            string str=Console.ReadLine();
            int len=str.Length;
            Console.WriteLine(len);
        }
    }
}
