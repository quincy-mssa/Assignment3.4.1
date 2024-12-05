namespace Assignment3._4._1
{
    public abstract class Beverage
    {
        public double SizeInOunces { get; set; }
        public string BeverageName { get; set; }
        public double BeveragePrice { get; set; }
        public string OrderName { get; set; }

        protected Beverage(double sizeInOunces, string beverageName, double beveragePrice, string orderName)
        {
            SizeInOunces = sizeInOunces;
            BeverageName = beverageName;
            BeveragePrice = beveragePrice;
            OrderName = orderName;
        }

        public abstract double CalculatePrice();
    }
}
