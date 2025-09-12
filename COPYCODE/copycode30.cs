using System;

namespace COPYCODE
{
    //Count number of digits in a number
    public class copycode30
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enetr   number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }

            Console.WriteLine(count);
        }
        }
    }
