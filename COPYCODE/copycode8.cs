using System;

namespace COPYCODE
{
    //check two arrays are equal or not
    public class copycode8
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            bool status = true;

            if (arr1.Length != arr2.Length)
            {
                status = false;
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        status = false;
                        break;
                    }
                }
            }

            if (status)
            {
                Console.WriteLine("Both arrays are the same");
            }
            else
            {
                Console.WriteLine("Arrays are not the same");
            }


            
        }
    }
}
