using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COPYCODE
{
    //find second largest  element in array  //  second smaale
    public class copycode25
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int firstmax = int.MaxValue;
            int seconmax = int.MaxValue;
            foreach (int i in arr)
            {
                if (i < firstmax)
                {
                    seconmax = firstmax;
                    firstmax = i;

                }
                else if (i < seconmax && firstmax != seconmax)
                {
                    seconmax = i;
                }

            }

            Console.WriteLine(seconmax);
        }
        }
    }
