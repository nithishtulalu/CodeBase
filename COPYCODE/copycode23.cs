using System;

namespace COPYCODE
{
    //Check if array is sorted in ascending order

    public class copycode23
    {
        static  void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            bool issorted= true;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if(arr[i] > arr[i + 1])
                {
                    issorted = false;
                    break;

                }
            }

            if (issorted)
            {
                Console.WriteLine("Sorted");
            }
            else
            {
                Console.WriteLine("not sorted ");
            }



        }
    }
}
