using CarStorage;
using System;


namespace ConsoleApp2
{
     public class Van:Car
    {
        private int mileage = 0;
        private int carring = 100;
        private int maxCarring = 5000;

        public Van(int carring, int mileage, Insurance insurance, string carName, int id, double price=1000)
            :base(id,carName, price)
        {
            Carring = carring;
            Mileage = mileage;
            Insurance = insurance;
        }
        public Insurance Insurance { get; set; }
        public int Carrying { get; set; }
        public int Mileage
        {
            get => mileage;
            set
            {
                if(value<0)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    mileage = value;
                }
            }
        }

        public int Carring
        {
            get => carring;
            set
            {
                if (value < 0|| value>maxCarring)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    carring = value;
                }
            }
        }

        public override string Name => "Van";

        public override string GetSale()//
        {
            var saleSum = new Random().Next(5, 16);
            string discount = $" Discount is: {saleSum.ToString()}, new price is: { (Price - (saleSum / 100.0 * Price)).ToString()}";
            return discount;
        }
        public override int GetSpeed()
        {
            return 90;
        }
    }
}
