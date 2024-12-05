namespace Assignment3._4._1
{
    public enum Roast { Light, Medium, Dark }
    public enum Temperature { Hot, Iced }

    internal class Coffee : Beverage
    {
        public Roast CoffeeRoast { get; set; }
        public Temperature CoffeeTemperature { get; set; }

        public Coffee(double sizeInOunces, string beverageName, double beveragePrice, string orderName, Roast coffeeRoast, Temperature coffeeTemperature)
            : base(sizeInOunces, beverageName, beveragePrice, orderName)
        {
            CoffeeRoast = coffeeRoast;
            CoffeeTemperature = coffeeTemperature;
        }

        public override string ToString()
        {
            return $"{OrderName} - {BeverageName}, {SizeInOunces} oz, {CoffeeRoast} roast, {CoffeeTemperature}, ${BeveragePrice:F2}";
        }

        public override double CalculatePrice()
        {
            throw new System.NotImplementedException();
        }
    }
}
