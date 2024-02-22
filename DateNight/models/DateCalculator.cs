using System;
namespace DateNight.models
{
    public class DateCalculator
    {
        public DateCalculator()
        {

        }

        public string CoffeeCost { get; set; }
        public string DinnerCost { get; set; }
        public string MovieCost { get; set; }

        public String GetTotalCost()
        {
            decimal decCoffee, decDinner, decMovie;
            if (!decimal.TryParse(CoffeeCost, out decCoffee))
            {
                if (string.IsNullOrEmpty(CoffeeCost))
                {
                    throw new Exception("Invalid Coffee cost");
                }
            }

            if (!decimal.TryParse(DinnerCost, out decDinner))
            {
                if (string.IsNullOrEmpty(DinnerCost))
                {
                    throw new Exception("Invalid Dinner cost");
                }
            }

            if (!decimal.TryParse(MovieCost, out decMovie))
            {
                if (string.IsNullOrEmpty(MovieCost))
                {
                    throw new Exception("Invalid Movie cost");
                }
            }
          
            return (decCoffee + decDinner+ decMovie).ToString("C");
        }
    }
}
