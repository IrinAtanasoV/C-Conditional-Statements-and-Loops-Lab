using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int priceOfTicket = 0;
            if (age > 0 && age <= 18)
            {
                if (typeOfDay == "weekday")
                {
                    priceOfTicket = 12;
                    Console.WriteLine($"{priceOfTicket}$");
                }
                else if (typeOfDay == "weekend")
                {
                    priceOfTicket = 15;
                    Console.WriteLine($"{priceOfTicket}$");

                }
                else if (typeOfDay == "holiday") ;
                {
                    priceOfTicket = 5;
                    Console.WriteLine($"{priceOfTicket}$");
                }
            }
            else if (age > 18 && age <= 64)
            {
                if (typeOfDay == "weekday")
                {
                    priceOfTicket = 18;
                    Console.WriteLine($"{priceOfTicket}$");
                }
                else if (typeOfDay == "weekend")
                {
                    priceOfTicket = 20;
                    Console.WriteLine($"{priceOfTicket}$");

                }
                else if (typeOfDay == "holiday")
                {
                    priceOfTicket = 12;
                    Console.WriteLine($"{priceOfTicket}$");
                }

            }
            else if (age > 64 && age <= 122)
            {
                if (typeOfDay == "weekday")
                {
                    priceOfTicket = 12;
                    Console.WriteLine($"{priceOfTicket}$");
                }
                else if (typeOfDay == "weekend")
                {
                    priceOfTicket = 15;
                    Console.WriteLine($"{priceOfTicket}$");

                }
                else if (typeOfDay == "holiday")
                {
                    priceOfTicket = 10;
                    Console.WriteLine($"{priceOfTicket}$");
                }
            }
            else if (age <= 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            
        }
    }
}
