﻿using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {

            Add();
            Add();
            Add();
            Add2(2, 5);
            
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
            Console.WriteLine(result);
        }

        
    }
}
