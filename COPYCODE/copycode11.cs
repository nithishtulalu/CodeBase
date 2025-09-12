using System;

namespace COPYCODE
{
    //Find duplicate element in array
    public class copycode11
    {
        static void Main(string[] args)
        {
            string[] str1 = { "C#", "java", "ssms", "mongoDb" };
            string[] str2 = { "C#", "python", "sql", "mongoDb" };

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        Console.WriteLine(str1[i]);
                    }
                }
            }
        }
    }
}