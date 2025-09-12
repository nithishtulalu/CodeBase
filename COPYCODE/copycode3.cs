using System;

namespace COPYCODE
{
    //Fibonacci series
    public class copycode3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  How many  u want");
            int limit=int.Parse(Console.ReadLine());
            int first = 0, second = 1;
            for (int i = 0; i <= limit; i++)
            {
                int next=first+second;
                Console.WriteLine(next+" ");
                first = second;
                second = next;
            }
        }
    }
}
