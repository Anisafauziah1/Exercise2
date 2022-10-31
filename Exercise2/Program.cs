using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
    {
        class Program
        {


        //Array to be searched
        int[] anisa = new int[61];
        //Number of elements in the array
        int n;
        //Get the number of elements to store in the array
        int i;
        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of the elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 61))
                    break;
                else
                    Console.WriteLine("|rArray should have minimum 1 and maximum 61 elements.\n");
            }
        }