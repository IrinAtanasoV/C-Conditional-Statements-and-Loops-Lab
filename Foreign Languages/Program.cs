using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string language = Console.ReadLine();

            if (language == "USA" || language == "England")
            {
                Console.WriteLine("English");

            }
            else if (language == "Spain" || language == "Mexico" || language == "Argentina")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
