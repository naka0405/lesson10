using ConsoleApp2;
using System;


namespace CarStorage
{
    public class Car:IVehicle, IDiscount, IPrint
    {
        private double _price = 0;

        public Car(int id, string carName, double price)
        {
            CarName = carName;
            ID = id;
            Price = price;
        }
        public string CarName { get; set; }
        public int ID { get; set; }
        public string Color { get; set; }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                { _price = value; }
                else
                {
                    Console.WriteLine($"This price is invalid {value}!");
                }
            }
        }
        public virtual string Name => "Car";

        public virtual string  GetSale()//
        {
            var saleSum = new Random().Next(5, 20);           
            string discount = $" Discount is: {saleSum.ToString()} new price is: { (Price - (saleSum / 100.0 * Price)).ToString()}";
            return discount ;
        }
        protected bool isColorValid(string color)
        {
            return Enum.TryParse(color, out EnumColors result);
        }
        public override string ToString()
        {
            return $"Id:{ID}, Name:{Name}, Price {Price}";
        }

        public virtual int GetSpeed()
        {
            return 100;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}
