using System;

namespace COPYCODE
{
    public class copycode32
    {
        //Count odd and even digits in a number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a a Serice number");
            int num=int.Parse(Console.ReadLine());
            int oddcount = 0;
            int evencount = 0;

            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    evencount++;
                }
                else
                {
                    oddcount++;
                }
                num = num / 10;
            }

            Console.WriteLine(oddcount + "++" + evencount);

        }
    }
}
