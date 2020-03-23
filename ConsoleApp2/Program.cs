using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Puppy();
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
