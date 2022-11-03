
using System;

namespace Assignment1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] mark = { 89, 99, 36, 61, 77 };

            int highest = 0;
            for (int i = 0; i <= 4; i++)
            {

                if (mark[i] > highest)
                    highest = mark[i];
            }
            Console.WriteLine("The Highest Mark is :"+ highest);
            


        }
    }
}