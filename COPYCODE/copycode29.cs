using System;
using System.Linq;

namespace COPYCODE
{
    public class copycode29
    {
        //Palindrome number  and string
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr   Number");
            int num = int.Parse(Console.ReadLine());
            int org = num;
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num = num / 10;
            }
            Console.WriteLine(rev);
            if (org == rev)
            {
                Console.WriteLine("palndrom string");
            }
            else
            {
                Console.WriteLine("not palndrom string");
            }
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            string revr = new string(str.Reverse().ToArray());
            string orgs = str;

            if (orgs == revr)
            {
                Console.WriteLine("palndrom string");
            }
            else
            {
                Console.WriteLine("not palndrom string");
            }


        }
    }
}
