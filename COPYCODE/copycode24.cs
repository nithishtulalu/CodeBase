using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COPYCODE
{
    //Merge two arrays
    public class copycode24
    {
        static void Main(string[] args)
        {
            int[] num1 = { 1, 2, 3, 4, 5 };
            int[] num2 = { 6, 7, 8, 9, 10 };
            int[] mergarray = new int[num1.Length + num2.Length];

            for (int i = 0; i < num1.Length-1; i++)
            {
                mergarray[i] = num1[i];
            }

            for (int i = 1; i < num2.Length; i++)
            {
                mergarray[num1.Length+i] = num2[i];
            }

            foreach (int i in mergarray)
            {
                Console.WriteLine(i);
            }

        }
    }
}