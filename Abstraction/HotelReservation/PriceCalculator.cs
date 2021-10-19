using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class PriceCalculator
    {
        public static decimal CalculatePrice(decimal pricePerDay, int NumberOfDays, Season season, Discount discount)
        {
            int multiplier = (int)season;
            decimal discountMultiplier = (decimal)discount / 100;
            decimal pricerBeforeDiscount = NumberOfDays * pricePerDay * multiplier;

            decimal discountedAmount = pricerBeforeDiscount * discountMultiplier;
            decimal finalPrice = pricerBeforeDiscount - discountedAmount;

            return finalPrice;
        }
    }
}
