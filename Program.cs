﻿using System;

namespace _05.PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());  //Lets print a triangle using methods
            for (int line = 1; line <= n; line++)  //n-> number of lines to print
            {
                PrintLine(10, line); // 1 ->start; line-> end //we just replace Pair(1/line) ->(start/end) into Method
            }
            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(10, line);
            }

            static void PrintLine(int start, int length)
            {
                for (int i = start; i < start + length; i++)
                {
                    Console.Write(" {0}", i);

                }
                Console.WriteLine();
            }

        }
    }
}
