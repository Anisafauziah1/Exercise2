using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        //array of integers to hold values
        private int[] anisa = new int[61];
        private int cmp_count = 0; // number of comparasion
        private int mov_count = 0; // number of data movements

        // Number of elements in array
        private int n;

        void read()
        {
            while (true)
            {
                Console.Write("Enter the nimber of elements in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 61)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 61 elements \n");
            }
            Console.WriteLine("\n=======================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n=======================");
        }

