using System;


namespace ConsoleApp2
{
    public class Bike:IVehicle, IDiscount, IPrint
    {
        public string Name => "Bike!";
         public double Price { get; set; }

        public Bike( double price)
        {
            Price = price;
        }
        public string GetSale()
        {
            var saleSum = new Random().Next(5, 15);
            string discount = $" Discount is: {saleSum.ToString()}, new price is: { (Price - (saleSum / 100.0 * Price)).ToString()}";
            return discount;
        }

        public int GetSpeed()
        {
            return 15;
        }

        public void PrintInfo()
        {
            Console.WriteLine(Name);
        }
    }
}
