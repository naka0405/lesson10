using CarStorage;
using System;


namespace ConsoleApp2
{
    public class Minivan : Car
    {
        private int maxNumberOfSeats = 10;
        private int numberOfSeats = 4;
        public Minivan( int numberOfSeats, string carName, int id):base(id, carName, 1000 )
        {
            NumberOfSeats = numberOfSeats;            
        }
        public int NumberOfSeats
        {
            get => numberOfSeats;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    numberOfSeats = value;
                }
            }
        }

        //public override string GetSale()//
        //{
        //    var saleSum = new Random().Next(5, 25);
        //    return (Price - (saleSum / 100.0 * Price)).ToString();
        //}
        public override string ToString()
        {
            return base.ToString()+$",Number of seats {NumberOfSeats}";
        }
    }
}

