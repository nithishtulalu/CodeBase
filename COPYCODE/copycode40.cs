using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COPYCODE
{
    //1
    //22
    //333
    //4444
    //55555
    public class copycode40
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  a number ");
            int key = int.Parse(Console.ReadLine());
            for (int i = 1; i <= key; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

        }
    }
}