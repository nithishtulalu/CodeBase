using System;

namespace COPYCODE
{
    public class copycode1
    {
        //Swapping two numbers in two ways
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers::");
            int num1=int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());

            Console.WriteLine($"Before Swaping{num1} And {num2}");
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"After  Swaping{num1} And {num2}");
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine($"After Swaping{num1} And {num2}");

        }
    }
}
