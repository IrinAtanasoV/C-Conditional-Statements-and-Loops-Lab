using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            

           
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num1} X {i} = {num1 * i}");
                    
                }
            
        }
    }
}
