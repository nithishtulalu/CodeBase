using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COPYCODE
{
    public class copycode38
    {
//*
//**
//***
//****
//*****
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  a number");
            int num=int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1;j<=i; j++)
                {
                    Console.Write("^");
                }
                Console.WriteLine();
            }


        }
    }
}
