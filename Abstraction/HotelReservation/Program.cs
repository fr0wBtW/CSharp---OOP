using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{PriceCalculator.CalculatePrice(50.25m, 5, Season.Summer, Discount.VIP):F2}");
        }
    }
}
