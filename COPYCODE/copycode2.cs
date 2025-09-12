using System;

namespace COPYCODE
{
    public class copycode2
    {
        //Largest among three numbers
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
                Console.WriteLine(num1 + "is  gratter amongthree");
            else if(num2>num1 && num2 > num3)
                Console.WriteLine(num2 + "is  gratter amongthree");
            else Console.WriteLine(num3 + "is  gratter amongthree");

        }
    }
}
