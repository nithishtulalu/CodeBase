using System;

namespace COPYCODE
{
    //Reverse a number
    public class copycode12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num = num / 10;
            }
            Console.WriteLine(rev);

        }
    }



}