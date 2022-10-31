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

            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                anisa[i] = Int32.Parse(s1);
            }
        }
        //swaps the elements at index x with the element at index y
        void swap(int x, int y)
        {
            int temp;

            temp = anisa[x];
            anisa[x] = anisa[y];
            anisa[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, AF, k;
            if (low >= high)
                return;
            int mid = (low + high) / 2;

            //Partition the list into two parts:
            //one containing elements less that or equal to pivot
            //Outher containing elements greather than pivot

            i = low;
            AF = mid + 1;
            k = low;

            pivot = anisa[low];

            while (i <= AF)
            {
                //Search for an element greather than pivot
                while ((anisa[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;