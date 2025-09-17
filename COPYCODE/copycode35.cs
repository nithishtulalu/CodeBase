
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COPYCODE
{
    // rotate array by k postion
    public  class copycode35
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("Enter  key:");
            int key = int.Parse(Console.ReadLine());


            int[] rotated=new int[arr.Length];
            for(int i=0; i<arr.Length; i++)
            {
                rotated[i]=arr[(i+key)%arr.Length];
            }
            foreach (int i in rotated)
            {
                Console.Write(i);
            }
        }
    }
}
