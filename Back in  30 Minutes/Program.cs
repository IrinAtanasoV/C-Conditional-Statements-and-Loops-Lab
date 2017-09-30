using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_in__30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;
            
            {

            }
            if (minutes > 59)
            {
                minutes = minutes - 60;
                hours++;
                
                if (hours == 24)
                {
                    hours = 0;
                }
                Console.WriteLine($"{hours}:{minutes:D2}");
            }
            else
            {
                if (hours == 24)
                {
                    hours = 0;
                }
                Console.WriteLine($"{hours}:{minutes:D2}");
            }


        }
    }
}
