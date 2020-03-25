using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
     public interface IVehicle
    {
        string Name { get; }
        public int GetSpeed();
        //void PrintInfo();
        //interface IDiscount;// { double GetSale(); };
    }
}
