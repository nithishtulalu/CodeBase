using System;

namespace COPYCODE
{
    //Find duplicate element in array
    public class copycode11
    {
        static void Main(string[] args)
        {

// in two arrays
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


//in single array using   linq
string[] names = { "Nithish", "Chandu", "Ravi", "Nithish", "Arjun", "Chandu", "Ravi", "Kiran" };

var duplicates = names.GroupBy(x => x)
    .Where(g => g.Count() > 1)
    .Select(g => g.Key);

Console.WriteLine("Duplicate names: " + string.Join(", ", duplicates));
        }
    }
}
