using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Puppy();
            //var  vehicles=new List<IVehicle>
            //var cars = new List<Car>
            var discounts= new List<IDiscount>
            {
                new Minivan(5,"BMW", 1),
                new Van(
                    100,
                    100000,
                new Insurance (DateTime.Now, DateTime.Now,"Nik NIk"),"Lada", 12000, 1000),
                new Minivan(5, "Kalina",15),
                new Bike(5200)
            };

            //foreach (var car in vehicles)
            //{
            //    Console.WriteLine(car.Name + " ");
            //    Console.WriteLine("Speed:" + car.GetSpeed());
            //}

            IVehicle van = new Van(
                100,
                100000,
                new Insurance(DateTime.Now, DateTime.Now, "Yulia Nechyporuk"),
                "Lada",
                10,
                12000);

            //van.PrintInfo();
            Console.WriteLine($"\t\nPrice with discount:");

            foreach (var car in discounts)
            {
                car.PrintInfo();
                Console.WriteLine( car.GetSale());
                Console.WriteLine("\n");
            }

            //foreach (var car in vehicles)
            //{
            //    Console.WriteLine(");
            //}
        }


        public class Animal
        {
            public Animal()
            {
                Console.WriteLine("Hi from Animal");
            }
        }

        public class Dog : Animal
        {
            public Dog() {
                Console.WriteLine("Hi from Dog");
            }
        }

        public class Puppy : Dog
        {
            public Puppy()
            {
                Console.WriteLine("Hi from Puppy!!");
            }
        }
    }
}
