﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (true)
                {
                    Console.WriteLine("It is a number.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
                
            }
        }
    }
}
