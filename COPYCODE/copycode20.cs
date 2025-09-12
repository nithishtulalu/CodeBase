using System;

namespace COPYCODE
{

    //Prime Number within range
    public class copycode20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter   strating num");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending number ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"Prime Number Betwwen  {start} and {end} are");
            for (int i = start; i < end; i++)
            {
                bool isprime = true;
                if (i <= 0)
                {
                    isprime = false;
                }
                else
                {
                    for (int j = 2; j <= i / j; j++)
                    {
                        if (i % j == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }

                }

                if (isprime)
                {
                    Console.WriteLine(i + "is prime");
                }


            }
        }
    }
}