using System;
using System.Collections.Generic;

namespace COPYCODE
{

    //Remove duplicates in array
    public class copycode13
    {
        static void Main( string[] args)
        {
            int[] arrWithDuplicates = { 1, 3, 5, 3, 7, 9, 1, 5, 11 };
            HashSet<int> arr = new HashSet<int>();
            foreach (int i in arrWithDuplicates) { 
                arr.Add(i);
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }


        }
    }
}
